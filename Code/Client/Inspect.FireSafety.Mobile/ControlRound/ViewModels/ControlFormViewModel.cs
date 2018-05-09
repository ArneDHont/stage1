using Acr.UserDialogs;
using AutoMapper;
using Inspect.FireSafety.Mobile.ControlRound.Models;
using Inspect.FireSafety.Mobile.ControlRound.Views;
using Inspect.FireSafety.WebApi.Locations;
using Inspect.FireSafety.WebApi.OrganisationUnits;
using Inspect.Framework.Hypermedia;
using Inspect.Mobile.Framework.Xamarin.Logging;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspect.FireSafety.Mobile.ControlRound.ViewModels
{
    public class ControlFormViewModel : ViewModelBase, IAppearingAware
    {
        private static readonly ILogger sLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IMapper mapper;
        private OrganisationUnitModel selectedOrganisationUnit;
        private List<OrganisationUnitModel> organisationUnits;
        private bool locationSelected;
        private ICommand refreshCommand;
        private LocationModel selectedLocation;
        private List<LocationModel> locations;
        private ICommand startControlCommand;
        private DateTime selectedDate = DateTime.Now.Date.AddDays(-1);

        public ICommand RefreshCommand
        {
            get { return refreshCommand ?? (refreshCommand = new Command(async () => await GetOrganisationUnitsAsync())); }
        }
        public long MaxDate { get { return (long)(DateTime.Now.Date - new DateTime(1970, 1, 1)).TotalMilliseconds; } } 
        public long MinDate { get { return (long)(new DateTime(1970, 1, 1) - new DateTime()).TotalMilliseconds; } }
        public DateTime SelectedDate
        {
            get { return selectedDate; }
            set
            {
                if (value.Date > DateTime.Now)
                {
                    UserDialogs.Instance.Alert("De geselecteerde datum kan niet.", "Verkeerde datum", "ok");
                }
                else
                {
                    selectedDate = value;
                }
                RaisePropertyChanged();
            }
        }        
        public OrganisationUnitModel SelectedOrganisationUnit
        {
            get { return selectedOrganisationUnit; }
            set
            {
                if (selectedOrganisationUnit != value)
                {
                    selectedOrganisationUnit = value;
                    RaisePropertyChanged();
                    if (selectedOrganisationUnit != null) new Command(async () => await GetOrganisationUnitLocations()).Execute(null);
                }
            }
        }
        public List<OrganisationUnitModel> OrganisationUnits
        {
            get { return organisationUnits; }
            set
            {
                organisationUnits = value;
                RaisePropertyChanged();
            }
        }
        public bool LocationSelected
        {
            get { return locationSelected; }
            set
            {
                locationSelected = value;
                RaisePropertyChanged();
            }
        }
        public LocationModel SelectedLocation
        {
            get
            {
                return selectedLocation;
            }
            set
            {
                selectedLocation = value;
                if (selectedLocation != null) LocationSelected = true;
                else LocationSelected = false;
                RaisePropertyChanged();
            }
        }
        public ICommand StartControl
        {
            get { return startControlCommand ?? (startControlCommand = new Command(async () => await NavigateAsync())); }
        }
        public List<LocationModel> Locations
        {
            get { return locations; }
            set
            {
                locations = value;
                SelectedLocation = null;
                RaisePropertyChanged();
            }
        }

        public ControlFormViewModel()
        {
            Title = "Controle";
            LocationSelected = false;
        }
        
        
        private async Task NavigateAsync()
        {
            var page = await NavigationService.PushAsync<IControlOverviewPage>();
            page.ViewModel.SelectedDate = SelectedDate;
            page.ViewModel.OrganisationUnitId = SelectedOrganisationUnit.OrganisationUnitId;
            page.ViewModel.LocationId = SelectedLocation.LocationId;
        }

        
        public async Task AppearingAsync()
        {
                await GetOrganisationUnitsAsync();
                Locations = null;
        }


        /**
         *  Fills the list with OrganisationUnits from the database 
         */
        public async Task GetOrganisationUnitsAsync()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("laden...");
                sLogger.GettingOrganisationUnitsStarted();
                var config = new MapperConfiguration(cfg => { cfg.CreateMap<OrganisationUnitRepresentation, OrganisationUnitModel>(); });
                mapper = config.CreateMapper();
                var response = await Client.GetEnsureAsync<CollectionRepresentation<OrganisationUnitRepresentation>>(new Uri("fire-safety/organisation-units", UriKind.Relative), CancellationToken.None);
                OrganisationUnits = new List<OrganisationUnitModel>(mapper.Map<IEnumerable<OrganisationUnitModel>>(response.Elements));
                SelectedLocation = null;
                sLogger.GetOrganisationUnitsCompleted();
                UserDialogs.Instance.HideLoading();
            }
            catch (Exception e)
            {
                UserDialogs.Instance.Alert("Er is een probleem opgetreden tijdens het ophalen van de gegevens, controleer jouw internetverbinding en klik op refresh", "netwerk error", "ok");
                sLogger.GetOrganisationUnitsFailed(e);
            }
        }


        /**
         * This fills the locations list filtered with the selected organisationUnit 
         */
        public async Task GetOrganisationUnitLocations()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("laden...");
                sLogger.GettingLocationsStarted();
                var config = new MapperConfiguration(cfg => { cfg.CreateMap<LocationRepresentation, LocationModel>(); });
                mapper = config.CreateMapper();
                var response = await Client.GetEnsureAsync<CollectionRepresentation<LocationRepresentation>>("fire-safety/organisation-units/" + SelectedOrganisationUnit.OrganisationUnitId + "/locations").ConfigureAwait(false);
                Locations = new List<LocationModel>(mapper.Map<IEnumerable<LocationModel>>(response.Elements));
                sLogger.GetLocationsCompleted();
                UserDialogs.Instance.HideLoading();
            }
            catch (Exception e)
            {

                UserDialogs.Instance.Alert("Er is een probleem opgetreden tijdens het ophalen van de gegevens, controleer jouw internetverbinding en klik op refresh", "netwerk error", "ok");
                sLogger.GetLocationsFailed(e);
            }
        }
    }
}