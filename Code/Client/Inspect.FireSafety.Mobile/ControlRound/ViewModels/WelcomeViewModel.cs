using Acr.UserDialogs;
using AutoMapper;
using Inspect.FireSafety.Mobile.ControlRound.Models;
using Inspect.FireSafety.Mobile.ControlRound.Views;
using Inspect.FireSafety.WebApi.Contracts.Equipment;
using Inspect.FireSafety.WebApi.Equipment;
using Inspect.FireSafety.WebApi.EquipmentTypes;
using Inspect.FireSafety.WebApi.Inspections;
using Inspect.Framework.Hypermedia;
using Inspect.Mobile.Framework.Xamarin.Barcode;
using Inspect.Mobile.Framework.Xamarin.Logging;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Inspect.Mobile.Framework.Xamarin.Security;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspect.FireSafety.Mobile.ControlRound.ViewModels
{
    public class WelcomeViewModel : ViewModelBase, IAppearingAware
    {
        private static readonly ILogger sLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IMapper mapper;
        private IUser _operator;
        private IUser _backupOperator;
        private bool addVisable;
        private ICommand addUser;
        private ICommand scanCommand;
        private ICommand typeCommand;
        private ICommand controlCommand;
        private ICommand logoutCommand;

        public ICommand ScanCommand
        {
            get
            {
                return scanCommand ?? (scanCommand = new Command(async () => await ScanItemAsync()));
            }
        }
        public ICommand TypeCommand
        {
            get
            {
                return typeCommand ?? (typeCommand = new Command(async () => await TypeItemAsync()));
            }
        }
        public ICommand ControlCommand
        {
            get
            {
                return controlCommand ?? (controlCommand = new Command(async () => await ControlAsync()));
            }
        }
        public IUser Operator
        {
            get { return _operator; }
            set
            {
                _operator = value;
                RaisePropertyChanged();
            }
        }
        public IUser BackupOperator
        {
            get { return _backupOperator; }
            set
            {
                _backupOperator = value;
                if (value == null) AddVisable = true;
                else AddVisable = false;
                RaisePropertyChanged();
            }
        }
        public bool AddVisable
        {
            get { return addVisable; }
            set
            {
                addVisable = value;
                RaisePropertyChanged();
            }
        }
        public ICommand AddUser
        {
            get
            {
                return addUser ?? (addUser = new Command(async () => await AddUserAsync()));
            }
        }
        public ICommand LogoutCommand
        {
            get
            {
                return logoutCommand ?? (logoutCommand = new Command<IUser>(async arg => await LogoutUserAsync(arg)));
            }
        }
        public InspectionItemModel ScannedItem { get; private set; }

        public WelcomeViewModel()
        {
        }

        /**
         * navigates to start a control
         */
        private async Task ControlAsync()
        {
            var page = await NavigationService.PushAsync<IControlFormPage>();
        }

        /**
         * In this method the user enter a code in and it searches the equipment
         */
        private async Task TypeItemAsync()
        {
            try
            {
                sLogger.SearchingEquipmentStared();
                var code = await UserDialogs.Instance.PromptAsync("", "", "zoeken", null, "Vul code in");
                if (code.Ok)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<InspectionRepresentation, InspectionItemModel>();
                        cfg.CreateMap<EquipmentRepresentation, EquipmentModel>();
                        cfg.CreateMap<EquipmentLocationRepresentation, LocationModel>();
                        cfg.CreateMap<EquipmentTypeRepresentation, TypeModel>();
                        cfg.CreateMap<EquipmentIdentificationRepresentation, EquipmentIdentificationModel>();

                    });
                    mapper = config.CreateMapper();

                    var response = await Client.GetAsync<EquipmentRepresentation>(new Uri("fire-safety/equipment/barcode/" + code.Text.ToUpper(), UriKind.Relative), CancellationToken.None);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ScannedItem = new InspectionItemModel() { Equipment = mapper.Map<EquipmentModel>(response.EnsureContent<EquipmentRepresentation>()) };
                        await NavigateAsync();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        UserDialogs.Instance.Alert("Het ingegeven toestel met code \n' " + code.Text.ToUpper() + "'\n is niet terug gevonden.", "Niet gevonden", "ok");
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Er is een probleem opgetreden tijdens het ophalen van de gegevens.", "error", "ok");
                    }
                }
            }
            catch (Exception e)
            {
                sLogger.FailedToFindEquipment(e);
            }
        }


        private async Task AddUserAsync()
        {
            var page = await NavigationService.PushModalAsync<IAddPersonPage>();
        }

        /**
         * This method logout the user 
         */
        private async Task LogoutUserAsync(IUser user)
        {
            sLogger.LoggingOutUser(user.FirstName);
            if (user.UserId == UserService.Operator.UserId)
            {
                if (UserService.BackupOperator == null)
                {
                    UserService.Operator = null;
                }
                else
                {
                    UserService.Operator = new UserModel(UserService.BackupOperator);
                    UserService.BackupOperator = null;
                }


            }
            else
            {
                UserService.BackupOperator = null;
            }
            if (UserService.Operator == null && UserService.BackupOperator == null)
            {
                await NavigationService.PopAsync();
            }
            else
            {
                await AppearingAsync();
            }

        }

        /**
         *  The scanner read the QR-code and than searches the equipment.          
         */
        public async Task ScanItemAsync()
        {
            try
            {
                IBarcodeScannerReport scanReport;
                using (CancellationTokenSource cancellationSource = new CancellationTokenSource())
                {
                    using (var dialog = UserDialogs.Instance.Loading("Scanning", () => cancellationSource.Cancel()))
                    {
                        sLogger.Scanning();
                        var scanner = await GetService<IBarcodeScannerService>().GetDefaultAsync();
                        scanReport = await scanner.ScanAsync(cancellationSource.Token);
                        dialog.Hide();
                        sLogger.ScanningCompleted();
                    }
                }

                if (scanReport != null)
                {
                    UserDialogs.Instance.Toast(scanReport.ScanDataLabel);
                    var config = new MapperConfiguration(cfg =>
                        {
                            cfg.CreateMap<InspectionRepresentation, InspectionItemModel>();
                            cfg.CreateMap<EquipmentRepresentation, EquipmentModel>();
                            cfg.CreateMap<EquipmentLocationRepresentation, LocationModel>();
                            cfg.CreateMap<EquipmentTypeRepresentation, TypeModel>();
                            cfg.CreateMap<EquipmentIdentificationRepresentation, EquipmentIdentificationModel>();

                        });
                    mapper = config.CreateMapper();

                    var response = await Client.GetAsync<EquipmentRepresentation>(new Uri("fire-safety/equipment/barcode/" + scanReport.ScanDataLabel, UriKind.Relative), CancellationToken.None);
                    ScannedItem = new InspectionItemModel() { Equipment = mapper.Map<EquipmentModel>(response.EnsureContent<EquipmentRepresentation>()) };
                    await NavigateAsync();

                }
            }catch(Exception e)
            {
                sLogger.ScanningFailed(e);
            }
        }

        private async Task NavigateAsync()
        {
            var page = await NavigationService.PushAsync<IEquipmentDetailPage>();
            page.ViewModel.SelectedItem = ScannedItem;
            if (ScannedItem.Equipment.BrandblusCodeID == 4) page.ViewModel.IsCo2 = true;
            else page.ViewModel.IsCo2 = false;
            page.ViewModel.IsVisible = false;
            page.ViewModel.EditCommand = new Command(() => { page.ViewModel.IsVisible = true; }, () => { return page.ViewModel.IsVisible; });
        }

        public Task AppearingAsync()
        {
            Operator = UserService.Operator;
            BackupOperator = UserService.BackupOperator;
            return Task.CompletedTask;
        }

    }
}
