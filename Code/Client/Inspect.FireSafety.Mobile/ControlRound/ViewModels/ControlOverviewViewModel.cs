using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Inspect.FireSafety.Mobile.ControlRound.Views;
using System.Threading;
using System.Linq;
using Inspect.FireSafety.Mobile.ControlRound.Models;
using Acr.UserDialogs;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Inspect.Framework.Hypermedia;
using Inspect.FireSafety.WebApi.Equipment;
using AutoMapper;
using Inspect.FireSafety.WebApi.Inspections;
using Inspect.FireSafety.WebApi.EquipmentTypes;
using Inspect.FireSafety.WebApi.InspectionEquipmentFeedbacks;
using Inspect.Mobile.Framework.Xamarin.Security;
using Inspect.Mobile.Framework.Xamarin;
using Plugin.Media.Abstractions;
using Inspect.Mobile.Framework.Xamarin.IO;
using System.IO;
using Inspect.FireSafety.WebApi.Contracts.InspectionSummary;
using Inspect.Mobile.Framework.Xamarin.Barcode;
using Inspect.FireSafety.WebApi.Contracts.Equipment;
using Inspect.FireSafety.WebApi.InspectionSummary;
using Inspect.Mobile.Framework.Xamarin.Logging;

namespace Inspect.FireSafety.Mobile.ControlRound.ViewModels
{
    public class ControlOverviewViewModel : ViewModelBase, IHandleAsync<InspectionCompleteMessage>, IPoppedAware, IPushedAware
    {
        private static readonly ILogger sLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private DateTime Start;
        private string totalString;
        private double controleProgress;
        private DateTime Stop;
        private ICommand itemClickCommand;
        private IMapper mapper;
        private ObservableCollection<InspectionItemModel> displayedDevices;
        private int locationId;
        private int organisationUnitId;
        private bool listVisible = true;
        private bool labelVisible = false;
        private Command stopCommand;
        private ICommand scanCommand;
        private ICommand filterCommand;
        private ICommand selectedCommand;
        private ICommand typeCommand;
        private string filterWord;
        private bool inspectionVisable = false;

        public DateTime SelectedDate { get; set; }
        public bool LabelVisible
        {
            get { return labelVisible; }
            set
            {
                labelVisible = value;
                RaisePropertyChanged();
            }
        }
        public bool ListVisible
        {
            get { return listVisible; }
            set
            {
                listVisible = value;
                RaisePropertyChanged();
            }
        }
        public string TotalString
        {
            get
            {
                return totalString;
            }
            set
            {
                totalString = value;
                RaisePropertyChanged();
            }
        }
        public double ControleProgress
        {
            get { return controleProgress; }
            set
            {
                controleProgress = value;
                RaisePropertyChanged();
            }
        }
        public bool CanExecuteStop { get; set; }
        public ICommand ScanCommand
        {
            get
            {
                return scanCommand ?? (scanCommand = new Command(async () => await ScanItemAsync()));
            }
        }
        public ICommand StopCommand
        {
            get
            {
                return stopCommand ?? (stopCommand = new Command(async () => await InspectionStopedAsync()));
            }
        }
        public List<EquipmentReportItemModel> ReportItems { get; set; }
        public ICommand FilterCommand
        {
            get
            {
                return filterCommand ?? (filterCommand = new Command<string>((filterWoord) => { this.filterWord = filterWoord; Filter(); })); 
            }
        }
        public ICommand SelectedCommand
        {
            get
            {
                return selectedCommand ?? (selectedCommand = new Command(async () => await NavigateAsync()));
            }
        }
        public ObservableCollection<InspectionItemModel> DisplayedDevices
        {

            get { return displayedDevices; }
            set
            {
                displayedDevices = value;
                if (value == null)
                {

                    InspectionVisable = false;
                }
                else
                {

                    InspectionVisable = true;
                }
                RaisePropertyChanged();
            }


        }
        public InspectionItemModel SelectedItem { get; set; }
        public List<InspectionItemModel> DevicesToInspect { get; set; }
        public List<InspectionItemModel> DevicesInspected { get; set; }
        public List<InspectionItemModel> DevicesOk { get; set; }
        public List<InspectionItemModel> DevicesNotOk { get; set; }
        public ICommand ItemClickCommand
        {
            get
            {
                return itemClickCommand ?? (itemClickCommand = new Command(async () => await NavigateAsync()));
            }

        }
        public bool InspectionVisable
        {
            get
            {
                return inspectionVisable;
            }
            set
            {
                inspectionVisable = value;
                RaisePropertyChanged();
            }
        }
        public int OrganisationUnitId
        {
            get { return organisationUnitId; }
            set
            {
                organisationUnitId = value;
            }
        }
        public int LocationId
        {
            get { return locationId; }
            set
            {
                locationId = value;
                new Command(async () => await LoadItemsAsync()).Execute(null);

            }
        }
        public ICommand TypeCommand
        {
            get
            {
                return typeCommand ?? (typeCommand = new Command(async () => await TypeItemAsync()));
            }
        }


        public ControlOverviewViewModel()
        {
            Title = "Overzicht";
            ControleProgress = 0;
        }
        public ControlOverviewViewModel(IMessenger messenger) : base(messenger)
        {

        }

        /**
         * This is the filter of the overview. The display list changes if the filterWord changed.         * 
         */
        public void Filter()
        {
            switch (filterWord)
            {
                case "ToScan": DisplayedDevices = new ObservableCollection<InspectionItemModel>(DevicesToInspect); break;
                case "Scanned": DisplayedDevices = new ObservableCollection<InspectionItemModel>(DevicesInspected); break;
                case "Ok": DisplayedDevices = new ObservableCollection<InspectionItemModel>(DevicesOk); break;
                case "NotOK": DisplayedDevices = new ObservableCollection<InspectionItemModel>(DevicesNotOk); break;
            }
            TotalString = DisplayedDevices.Count + "/" + (DevicesInspected.Count + DevicesToInspect.Count);
            sLogger.FilterChanged(filterWord);
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

                    if (DevicesToInspect.Count != 0)
                    {
                        SelectedItem = DevicesToInspect.FirstOrDefault(x => x.Equipment.EquipmentIdentifications.Any(z => z.Value == scanReport.ScanDataLabel));

                        if (SelectedItem == null)
                        {
                            SelectedItem = DevicesInspected.FirstOrDefault(x => x.Equipment.EquipmentIdentifications.Any(z => z.Value == scanReport.ScanDataLabel));
                            if (SelectedItem != null)
                            {
                                var goDetail = await UserDialogs.Instance.ConfirmAsync("U hebt dit toestel al eens gecontroleerd wilt u de details bekijken?", "Detail toestel", "Ja", "Neen", null);
                                if (goDetail) await NavigateAsync();
                            }
                            else
                            {
                                UserDialogs.Instance.Alert("Dit toestel zit niet in deze controle ronde", "verkeerd toestel", "ok");
                            }
                        }
                        else
                        {
                            await NavigateAsync();
                        }
                    }

                }
            }
            catch (Exception e)
            {
                UserDialogs.Instance.Alert("Het scannen is niet gelukt", "scanner error", "ok");
                sLogger.ScanningFailed(e);
            }
        }


        /**
         *  this mothed checks if the inspectionround is over.          
         */
        public async Task CheckEndControlAsync()
        {
            sLogger.CheckEndControl();
            if (DevicesToInspect.Count == 0)
            {

                Stop = DateTime.Now;
                await UserDialogs.Instance.AlertAsync("De Ronde is gedaan", null, "ok");
                var inspectionSummary = new InspectionSummaryRepresentationForCreation();
                inspectionSummary.OperatorId = UserService.Operator.UserId;
                inspectionSummary.BackupOperatorId = UserService.BackupOperator?.UserId;
                inspectionSummary.OrganisationUnitId = OrganisationUnitId;
                inspectionSummary.LocationId = LocationId;
                inspectionSummary.DateStarted = Start;
                inspectionSummary.DateFinished = Stop;
                inspectionSummary.Completed = true;
                inspectionSummary.TotalToInspect = DevicesInspected.Count + DevicesToInspect.Count;
                inspectionSummary.TotalInspected = DevicesInspected.Count;
                inspectionSummary.TotalApproved = DevicesOk.Count;
                inspectionSummary.TotalDisApproved = DevicesNotOk.Count;
                inspectionSummary.Remarks = "";
                var config = new MapperConfiguration(cfg => { cfg.CreateMap<EquipmentReportItemModel, EquipmentReportItemRepresentation>(); });
                mapper = config.CreateMapper();
                inspectionSummary.ReportItems = mapper.Map<List<EquipmentReportItemRepresentation>>(ReportItems);
                inspectionSummary.ReportItems = mapper.Map<List<EquipmentReportItemRepresentation>>(ReportItems);
                var response = await Client.PostEnsureAsync("fire-safety/inspectionsummary", inspectionSummary);
                await NavigationService.RemovePage<IControlFormPage>();
                await NavigationService.PopAsync();
                sLogger.CheckEndControlCompleted();
            }
        }

        private async Task NavigateAsync()
        {
            var page = await NavigationService.PushAsync<IEquipmentDetailPage>();
            page.ViewModel.SelectedItem = SelectedItem;
            if (SelectedItem.Equipment.BrandblusCodeID == 4) page.ViewModel.IsCo2 = true;
            else page.ViewModel.IsCo2 = false;
            if (DevicesToInspect == null)
            {
                page.ViewModel.IsVisible = false;
            }
            else
            {
                if (SelectedItem.Equipment.DateVisualInspection.HasValue)
                {
                    page.ViewModel.IsVisible = (SelectedItem.Equipment.DateVisualInspection.Value.Date == DateTime.Now.Date) ? false : true;
                    page.ViewModel.EditCommand = new Command(() => { page.ViewModel.IsVisible = true; }, () => { return !page.ViewModel.IsVisible; });
                }
                else
                {
                    page.ViewModel.IsVisible = true;
                }
            }

            UserDialogs.Instance.HideLoading();
        }


        /**
         *This method fills the DevicesToInpect from the database and set the displayed list to it. 
         */
        private async Task GetInspectionItemsAsync()
        {
            try
            {
                sLogger.GettingInspectionItemsStarted();
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<InspectionRepresentation, InspectionItemModel>();
                    cfg.CreateMap<EquipmentRepresentation, EquipmentModel>();
                    cfg.CreateMap<EquipmentLocationRepresentation, LocationModel>();
                    cfg.CreateMap<EquipmentTypeRepresentation, TypeModel>();
                    cfg.CreateMap<EquipmentIdentificationRepresentation, EquipmentIdentificationModel>();

                });
                mapper = config.CreateMapper();

                var response = await Client.GetEnsureAsync<CollectionRepresentation<InspectionRepresentation>>("fire-safety/inspections?locationid=" + LocationId + "&SelectedDate=" + SelectedDate.ToString("s")).ConfigureAwait(false);
                DevicesToInspect = new List<InspectionItemModel>(mapper.Map<IEnumerable<InspectionItemModel>>(response.Elements));
                DisplayedDevices = new ObservableCollection<InspectionItemModel>(DevicesToInspect);
                sLogger.GetInspectionItemsCompleted();
            }
            catch (Exception e)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Er is een probleem opgetreden tijdens het ophalen van de gegevens", "netwerk error", "ok");
                sLogger.GetInspectionItemsFailed(e);
            }


        }

        /**
         * This method initialise the tings needed and checks if there are itmes to display.
         */
        private async Task LoadItemsAsync()
        {
            try
            {
                sLogger.LoadInspectionItemsStarted();
                UserDialogs.Instance.ShowLoading("laden...");
                await GetInspectionItemsAsync();
                ReportItems = new List<EquipmentReportItemModel>();
                DevicesInspected = new List<InspectionItemModel>();
                DevicesOk = new List<InspectionItemModel>();
                DevicesNotOk = new List<InspectionItemModel>();
                TotalString = DisplayedDevices.Count + "/" + (DevicesInspected.Count + DevicesToInspect.Count);
                if (DevicesInspected.Count == 0 && DevicesToInspect.Count == 0)
                {
                    LabelVisible = true;
                    ListVisible = false;
                }
                else
                {
                    LabelVisible = false;
                    ListVisible = true;
                }
                UserDialogs.Instance.HideLoading();
                sLogger.LoadInspectionItemsCompleted();
            }catch(Exception e)
            {
                sLogger.LoadInspectionItemsFailed(e);
            }
        }

        /**
         * This method handle the message send from the ok page or not ok page
         */
        public async Task HandleAsync(InspectionCompleteMessage message, CancellationToken cancellationToken)
        {
            sLogger.FeedbackMessageSended();
            UserDialogs.Instance.ShowLoading("opslaan...");
            var device = DevicesToInspect.FirstOrDefault(x => x.Equipment.EquipmentId == message.EquipmentId);
            if (device == null)
            {
                device = DevicesInspected.FirstOrDefault(x => x.Equipment.EquipmentId == message.EquipmentId);
                if (device == null)
                {
                    await UserDialogs.Instance.AlertAsync("Dit toestel is niet gevonden", "save error", "ok");
                    return;
                }
                device.Equipment.DateVisualInspection = DateTime.Now;
                if (device.Status == StatusTypes.Ok)
                {
                    DevicesOk.Remove(device);
                    device.Color = Color.Red;
                    device.Status = StatusTypes.Not_Ok;
                    DevicesNotOk.Add(device);
                    await UpdateToDatabase(device, message.Result, message.Vera, message.Photos, message.Weight, message.FeedbackType.FeedbackTypeId, message.Remarks);
                }
                else
                {
                    DevicesNotOk.Remove(device);
                    device.Status = StatusTypes.Ok;
                    device.Color = Color.Green;
                    DevicesOk.Add(device);
                    await UpdateToDatabase(device, message.Result, message.Vera, message.Photos, message.Weight);
                }
                Filter();

            }
            else
            {
                if (message.Result == InspectionResult.Ok)
                {

                    device.Status = StatusTypes.Ok;
                    device.Color = Color.Green;
                    DevicesOk.Add(device);
                    await RefreshOverviewAsync(device);
                    await SaveToDatabase(device, message.Result, message.Vera, message.Photos, message.Weight);
                }
                if (message.Result == InspectionResult.NotOk)
                {

                    device.Color = Color.Red;
                    device.Status = StatusTypes.Not_Ok;
                    DevicesNotOk.Add(device);
                    var equipmentRaportItem = new EquipmentReportItemModel();
                    equipmentRaportItem.Equipment = device.Equipment.EquipmentLocation.Name;
                    equipmentRaportItem.LocationDescription = device.Equipment.EquipmentLocation.Description;
                    equipmentRaportItem.QRCode = device.Equipment.EquipmentIdentifications[0].Value;
                    equipmentRaportItem.FeedBack = message.FeedbackType.Description;
                    equipmentRaportItem.Remark = message.Remarks;
                    equipmentRaportItem.Vera = message.Vera;
                    ReportItems.Add(equipmentRaportItem);
                    await RefreshOverviewAsync(device);
                    await SaveToDatabase(device, message.Result, message.Vera, message.Photos, message.Weight, message.FeedbackType.FeedbackTypeId, message.Remarks);
                }
            }

            UserDialogs.Instance.HideLoading();
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
                    if (DevicesToInspect.Count != 0)
                    {
                        SelectedItem = DevicesToInspect.FirstOrDefault(x => x.Equipment.EquipmentIdentifications.Any(z => z.Value == code.Text.ToUpper()));

                        if (SelectedItem == null)
                        {
                            SelectedItem = DevicesInspected.FirstOrDefault(x => x.Equipment.EquipmentIdentifications.Any(z => z.Value == code.Text.ToUpper()));
                            if (SelectedItem != null)
                            {
                                var goDetail = await UserDialogs.Instance.ConfirmAsync("U hebt dit toestel al eens gecontroleerd wilt u de details bekijken?", "Detail toestel", "Ja", "Neen", null);
                                if (goDetail) await NavigateAsync();
                            }
                            else
                            {
                                UserDialogs.Instance.Alert("Dit toestel zit niet in deze controle ronde", "verkeerd toestel", "ok");
                            }
                        }
                        else
                        {
                            await NavigateAsync();
                        }
                    }

                }
            }
            catch (Exception e)
            {
                sLogger.FailedToFindEquipment(e);
            }
        }

        /**
         * This method refresh the display list afther an equipment is checked.
         */
        private async Task RefreshOverviewAsync(InspectionItemModel device)
        {
            sLogger.RefreshingOverview();
            device.Equipment.DateVisualInspection = DateTime.Now;
            DevicesInspected.Add(device);
            DevicesToInspect.Remove(device);
            ControleProgress = Math.Round((double)(DevicesInspected.Count) / (double)(DevicesInspected.Count + DevicesToInspect.Count), 4);
            DisplayedDevices = new ObservableCollection<InspectionItemModel>(DevicesToInspect);
            TotalString = DisplayedDevices.Count + "/" + (DevicesInspected.Count + DevicesToInspect.Count);
            await CheckEndControlAsync();
        }

        public Task PoppedAsync()
        {
            MessengerInstance.Unsubscribe(this);

            return Task.CompletedTask;
        }

        public Task PushedAsync()
        {
            MessengerInstance.Subscribe(this);
            Start = DateTime.Now;
            return Task.CompletedTask;
        }

        /**
         * If the user press the stop icon this method is called to safe a summery to the database
         */
        public async Task InspectionStopedAsync()
        {
            try
            {

                Stop = DateTime.Now;
                var TotalInspected = DevicesInspected.Count();
                var TotalApproved = DevicesOk.Count();
                var TotalDisApproved = DevicesNotOk.Count();
                var remark = await UserDialogs.Instance.PromptAsync("", "", "stoppen", null, "reden van afsluiten");
                sLogger.ControlRoundHasStopped(remark.Text);
                if (remark.Ok)
                {
                    var inspectionSummary = new InspectionSummaryRepresentationForCreation();
                    inspectionSummary.OperatorId = UserService.Operator.UserId;
                    inspectionSummary.BackupOperatorId = UserService.BackupOperator?.UserId;
                    inspectionSummary.OrganisationUnitId = OrganisationUnitId;
                    inspectionSummary.LocationId = LocationId;
                    inspectionSummary.DateStarted = Start;
                    inspectionSummary.DateFinished = Stop;
                    inspectionSummary.Completed = false;
                    inspectionSummary.TotalToInspect = DevicesInspected.Count + DevicesToInspect.Count;
                    inspectionSummary.TotalInspected = DevicesInspected.Count;
                    inspectionSummary.TotalApproved = DevicesOk.Count;
                    inspectionSummary.TotalDisApproved = DevicesNotOk.Count;
                    inspectionSummary.Remarks = remark.Text;
                    var config = new MapperConfiguration(cfg => { cfg.CreateMap<EquipmentReportItemModel, EquipmentReportItemRepresentation>(); });
                    mapper = config.CreateMapper();
                    inspectionSummary.ReportItems = mapper.Map<List<EquipmentReportItemRepresentation>>(ReportItems);
                    inspectionSummary.PLG_Mail = UserService.Operator.PLG_Mail;
                    var response = await Client.PostEnsureAsync("fire-safety/inspectionsummary", inspectionSummary);
                    DependencyService.Get<IApplicationService>().CloseApplication();
                }
            }catch(Exception e)
            {
                sLogger.SendStopSummeryFailed(e);
            }
        }

        /**
         *In this method the equipment feedback is saved to the database.
         */
        private async Task SaveToDatabase(InspectionItemModel device, InspectionResult result, bool vera, ObservableCollection<MediaFile> photos, double? weight, int? FeedbackTypeId = null, string remarks = null)
        {
            try
            {
                sLogger.SavedFeedbackToDatabaseStarted();
                var equipmentFeedback = new InspectionEquipmentFeedbackRepresentationForCreation();
                equipmentFeedback.EquipmentId = SelectedItem.Equipment.EquipmentId;
                equipmentFeedback.Weight = weight;
                equipmentFeedback.Status = result.ToString();
                equipmentFeedback.FeedbackTypeId = FeedbackTypeId;
                equipmentFeedback.Remark = remarks;
                equipmentFeedback.TimeCompleted = DateTime.Now;
                equipmentFeedback.OperatorId = UserService.Operator.UserId;
                equipmentFeedback.EquipmentLocationName = SelectedItem.Equipment.EquipmentLocation.Name;
                equipmentFeedback.EquipmentLocationDescription = SelectedItem.Equipment.EquipmentLocation.Description;
                equipmentFeedback.Vera = vera;
                var response = await Client.PostEnsureAsync("fire-safety/inspectionequipmentfeedback", equipmentFeedback);
                var href = response.Links.GetLink(WebApi.InspectionEquipmentFeedbacks.HypermediaLinks.Attachment);
                DevicesInspected.Where(x => x.Equipment.EquipmentId == device.Equipment.EquipmentId).SingleOrDefault().Equipment.LastFeedbackID = Int32.Parse(href.Href.Split('/')[4]); ;
                sLogger.SavedFeedbackToDatabaseCompleted();
                if (photos != null)
                {
                    sLogger.SaveFeedbackPhotosToDatabaseStarted();
                    var config = new MapperConfiguration(cfg => { cfg.CreateMap<IFileInfo, InspectionEquipmentFeedbackAttachmentRepresentationForCreation>().ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.CreationTime)).ForMember(dest => dest.FileName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Length)); });
                    mapper = config.CreateMapper();
                    foreach (MediaFile photo in photos)
                    {
                        IFileInfo metaData = GetService<IFileSystemService>().GetFileInfo(photo.Path);
                        var attachment = mapper.Map<InspectionEquipmentFeedbackAttachmentRepresentationForCreation>(metaData);
                        byte[] bytes = File.ReadAllBytes(photo.Path);
                        var ms = photo.GetStream();
                        var attachmentresponse = await Client.PostMultipartAsync(href.AsUri(), attachment, ms, CancellationToken.None);
                    }
                    sLogger.SaveFeedbackPhotosToDatabaseCompleted();
                }

            }
            catch (Exception e)
            {
                UserDialogs.Instance.Alert("Er is een probleem opgelopen tijdens het opslaan", "Save Error", "ok");
                sLogger.SavedFeedbackToDatabaseFailed(e);
            }


        }

        /**
         *In this method the equipment feedback is updated to the database.
         */
        private async Task UpdateToDatabase(InspectionItemModel device, InspectionResult result, bool vera, ObservableCollection<MediaFile> photos, double? weight, int? FeedbackTypeId = null, string remarks = null)
        {
            try
            {
                sLogger.UpdateFeedbackToDatabaseStarted();
                var equipmentFeedback = new InspectionEquipmentFeedbackRepresentationForCreation();
                equipmentFeedback.EquipmentId = SelectedItem.Equipment.EquipmentId;
                equipmentFeedback.Weight = weight;
                equipmentFeedback.Status = result.ToString();
                equipmentFeedback.FeedbackTypeId = FeedbackTypeId;
                equipmentFeedback.Remark = remarks;
                equipmentFeedback.TimeCompleted = DateTime.Now;
                equipmentFeedback.OperatorId = UserService.Operator.UserId;
                equipmentFeedback.EquipmentLocationName = SelectedItem.Equipment.EquipmentLocation.Name;
                equipmentFeedback.EquipmentLocationDescription = SelectedItem.Equipment.EquipmentLocation.Description;
                equipmentFeedback.Vera = vera;
                var response = await Client.PostEnsureAsync("fire-safety/inspectionequipmentfeedback/update/" + device.Equipment.LastFeedbackID, equipmentFeedback);
                var href = response.Links.GetLink(WebApi.InspectionEquipmentFeedbacks.HypermediaLinks.Attachment);
                sLogger.UpdateFeedbackToDatabaseCompleted();
                if (photos != null)
                {
                    sLogger.UpdateFeedbackPhotosToDatabaseStarted();
                    var config = new MapperConfiguration(cfg => { cfg.CreateMap<IFileInfo, InspectionEquipmentFeedbackAttachmentRepresentationForCreation>().ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.CreationTime)).ForMember(dest => dest.FileName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Length)); });
                    mapper = config.CreateMapper();
                    foreach (MediaFile photo in photos)
                    {
                        IFileInfo metaData = GetService<IFileSystemService>().GetFileInfo(photo.Path);
                        var attachment = mapper.Map<InspectionEquipmentFeedbackAttachmentRepresentationForCreation>(metaData);
                        byte[] bytes = File.ReadAllBytes(photo.Path);
                        var ms = photo.GetStream();
                        var attachmentresponse = await Client.PostMultipartAsync(href.AsUri(), attachment, ms, CancellationToken.None);
                    }
                    sLogger.UpdateFeedbackPhotosToDatabaseCompleted();
                }

            }
            catch (Exception e)
            {
                UserDialogs.Instance.Alert("Er is een probleem opgelopen tijdens het opslaan", "Save Error", "ok");
                sLogger.UpdateFeedbackToDatabaseFailed(e);
            }


        }

    }
}
