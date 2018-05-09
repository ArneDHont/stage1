using Acr.UserDialogs;
using AutoMapper;
using Inspect.FireSafety.Mobile.ControlRound.Models;

using Inspect.FireSafety.WebApi.Users;
using Inspect.Framework.Hypermedia;
using Inspect.Mobile.Framework.Xamarin.Logging;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Inspect.Mobile.Framework.Xamarin.Security;

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspect.FireSafety.Mobile.ControlRound.ViewModels
{
    public class AddPersonViewModel : ViewModelBase
    {
        private static readonly ILogger sLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IMapper mapper;
        private ICommand loginCommand;

        public string EmployeeNumber { get; set; }
        public string BadgeNumber { get; set; }
        public UserModel UserToAdd { get; set; }

        public AddPersonViewModel()
        {
            Title = "Persoon toevoegen";
        }

        public ICommand LoginCommand
        {
            get { return loginCommand ?? (loginCommand = new Command(async () => await LoginCheckAsync())); }
        }

        /**
         * This method checks if the backoperator is valid to access the application. 
         */
        private async Task LoginCheckAsync()
        {
            UserDialogs.Instance.ShowLoading("Logging in...");
            await GetUser();
            if (UserToAdd != null)
            {
                sLogger.ValidateUser();
                if (!UserToAdd.BRDW)
                {
                    sLogger.ValidateCompleted("The user is not a firefighter");
                    UserDialogs.Instance.Alert("U heeft geen toestemming voor deze applicatie.", "Login error", "ok");
                }
                else if (!UserToAdd.Active)
                {
                    sLogger.ValidateCompleted("The user is not active");
                    UserDialogs.Instance.Alert("U bent niet meer actief volgens de gegevens.", "Login error", "ok");
                }
                else
                {
                    if (UserToAdd.EmployeeNumber.Equals(UserService.Operator.EmployeeNumber)) UserDialogs.Instance.Alert("Deze user is al ingelogt", "Login error", "ok");
                    else
                    {
                        UserService.BackupOperator = UserToAdd;
                        await NavigationService.PopModalAsync();

                    }

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
                UserToAdd = null;
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
                    UserToAdd = mapper.Map<UserModel>(response.EnsureContent<UserRepresentation>());
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
