using Acr.UserDialogs;
using Android.App;
using AutoMapper;
using Inspect.FireSafety.Mobile.ControlRound.ViewModels;
using Inspect.FireSafety.Mobile.ControlRound.Views;
using Inspect.FireSafety.WebApi.Users;
using Inspect.Framework.Hypermedia;
using Inspect.Mobile.Framework.Xamarin.Logging;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Inspect.Mobile.Framework.Xamarin.Security;
using Inspect.Mobile.Models;
using Inspect.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspect.Mobile.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private static readonly ILogger sLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IMapper mapper;
        private ICommand loginCommand;

        public string EmployeeNumber { get; set; }
        public string BadgeNumber { get; set; }
        public UserModel LoginUser { get; set; }

        
        public LoginViewModel()
        {
            Title = "Login";
        }

        public ICommand LoginCommand
        {
            get { return loginCommand ?? (loginCommand = new Command(async () => await LoginCheckAsync())); }
        }


        /**
         * This method checks if the operator user is valid to access the application. 
         */
        private async Task LoginCheckAsync()
        {

            UserDialogs.Instance.ShowLoading("Logging in...");
            await GetUser();
            if (LoginUser != null)
            {
                sLogger.ValidateUser();
                if (!LoginUser.BRDW)
                {
                    sLogger.ValidateCompleted("The user is not a firefighter");
                    UserDialogs.Instance.Alert("U heeft geen toestemming voor deze applicatie.", "Login error", "ok");
                }
                else if (!LoginUser.Active)
                {
                    sLogger.ValidateCompleted("The user is not active");
                    UserDialogs.Instance.Alert("U bent niet meer actief volgens de gegevens.", "Login error", "ok");
                }
                else
                {
                    sLogger.ValidateCompleted();
                    UserService.Operator = LoginUser;
                    var page = await NavigationService.PushAsync<IWelcomePage>();
                    
                }
            }
            UserDialogs.Instance.HideLoading();
        }

        /**
         * This method gets the user from the database if exists  
         */
        public async Task GetUser()
        {
            try
            {
                LoginUser = null;
                var config = new MapperConfiguration(cfg => { cfg.CreateMap<UserRepresentation, UserModel>(); });
                mapper = config.CreateMapper();
                var response = await Client.GetAsync<UserRepresentation>(new Uri("fire-safety/users/" + EmployeeNumber, UriKind.Relative), CancellationToken.None);
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    UserDialogs.Instance.Alert("Het stamnummer is niet gevonden", "Login error", "ok");
                    sLogger.UserNotFound();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    LoginUser = mapper.Map<UserModel>(response.EnsureContent<UserRepresentation>());
                }

            }
            catch (Exception e)
            {
                UserDialogs.Instance.Alert("Er is een probleem opgetreden tijdens het inloggen", "Login error", "ok");
                sLogger.UserFailtLogin(e);
            }
        }        
    }
}
