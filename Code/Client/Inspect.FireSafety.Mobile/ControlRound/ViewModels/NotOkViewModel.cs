using Acr.UserDialogs;
using AutoMapper;
using Inspect.FireSafety.Mobile.ControlRound.Models;
using Inspect.FireSafety.Mobile.ControlRound.Views;
using Inspect.FireSafety.WebApi.FeedbackTypes;
using Inspect.Framework.Hypermedia;
using Inspect.Mobile.Framework.Xamarin.IO;
using Inspect.Mobile.Framework.Xamarin.Logging;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspect.FireSafety.Mobile.ControlRound.ViewModels
{
    public class NotOkViewModel : ViewModelBase, IHandleAsync<DeletePhotoMessage>, IPoppedAware, IPushedAware
    {
        private static readonly ILogger sLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IMapper mapper;
        private bool selectedOther = false;
        private TypeModel selectedType;
        private ICommand takePhoto;
        private ICommand cancelCommand;
        private ICommand pictureViewCommand;
        private ICommand saveCommand;
        private List<FeedbackTypeModel> feedbackTypes;
        private string remarks;
        private bool codeSelected = false;
        private ObservableCollection<MediaFile> photos;
        private FeedbackTypeModel feedbackType;


        public bool SelectedOther
        {
            get { return selectedOther; }
            set
            {
                selectedOther = value;
                RaisePropertyChanged();
            }
        }
        public bool CodeSelected
        {
            get { return codeSelected; }
            set
            {
                codeSelected = value;
                RaisePropertyChanged();
            }
        }
        public bool Vera { get; set; } = false;
        public TypeModel SelectedType
        {
            get { return selectedType; }
            set
            {
                selectedType = value;

                new Command(async () => await LoadFeedbackAsync()).Execute(null);
            }
        }
        public ICommand TakePhoto
        {
            get { return takePhoto ?? (takePhoto = new Command(() => TakePhotoAsync())); }
        }
        public ICommand SaveCommand
        {
            get { return saveCommand ?? (saveCommand = new Command(async () => await SaveAsync())); }
        }
        public ICommand CancelCommand
        {
            get { return cancelCommand ?? (cancelCommand = new Command(async () => await CancelAsync())); }
        }
        public ICommand PictureViewCommand
        {
            get { return pictureViewCommand ?? (pictureViewCommand = new Command(async () => await PictureViewAsync())); }
        }
        public MediaFile Photo
        {
            get;
            set;
        }
        public List<FeedbackTypeModel> FeedbackTypes
        {
            get { return feedbackTypes; }
            set
            {
                feedbackTypes = value;
                RaisePropertyChanged();
            }
        }
        public string Remarks
        {
            get { return remarks; }
            set
            {
                remarks = value;
                RaisePropertyChanged();
            }
        }
        public long EquipmentId { get; set; }
        public ObservableCollection<MediaFile> Photos
        {
            get { return photos; }
            set
            {
                photos = value;
                RaisePropertyChanged();
            }
        }
        public double? Weight { get; internal set; }
        public FeedbackTypeModel FeedbackType
        {
            get { return feedbackType; }
            set
            {
                if (feedbackType != value)
                {
                    feedbackType = value;
                    RaisePropertyChanged();
                    if (feedbackType == null) CodeSelected = false;
                    else CodeSelected = true;
                    if (FeedbackType.Description.Equals("andere...")) SelectedOther = true;
                    else SelectedOther = false;
                }

            }
        }


        public NotOkViewModel()
        {
            Photos = new ObservableCollection<MediaFile>();
            Title = "Niet ok";
        }

        /**
         * this fils the dropdown filtered by type  
         */
        private async Task LoadFeedbackAsync()
        {
            try
            {
                sLogger.GettingFeedbackItemsStarted();
                UserDialogs.Instance.ShowLoading("laden...");
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<FeedbackTypeRepresentation, InspectionItemModel>();
                });
                mapper = config.CreateMapper();
                var response = await Client.GetEnsureAsync<CollectionRepresentation<FeedbackTypeRepresentation>>("fire-safety/equipment-types/" + SelectedType.EquipmentTypeId + "/feedback-types").ConfigureAwait(false);
                FeedbackTypes = new List<FeedbackTypeModel>(mapper.Map<IEnumerable<FeedbackTypeModel>>(response.Elements.OrderBy(x => x.Description)));
                FeedbackTypes.Add(new FeedbackTypeModel() { Description = "andere...", FeedbackTypeId = 33 });
                UserDialogs.Instance.HideLoading();
                sLogger.GetFeedbackItemsCompleted();
            }catch(Exception e)
            {
                sLogger.GetFeedbackItemsFailed(e);
            }
        }

        /**
         * This method is for taking the picture using CrossMedia 
         * 
         * doc for CrossMedia https://github.com/jamesmontemagno/MediaPlugin
         */
        private async void TakePhotoAsync()
        {
            sLogger.TakingAPhoto();
            UserDialogs.Instance.ShowLoading("laden");
            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                DefaultCamera = CameraDevice.Rear
            });
            Photos.Add(file);
            UserDialogs.Instance.HideLoading();

        }

        /**
         * navigate to see the picure ful screen.
         */
        private async Task PictureViewAsync()
        {
            var page = await NavigationService.PushModalAsync<IPictureViewPage>();
            page.ViewModel.Photo = Photo;
        }

        /** 
         * checks if every thing is ok and than send a message to overview page for handeling.
         */
        private async Task SaveAsync()
        {
            if (selectedOther && Remarks == null)
            {
                UserDialogs.Instance.Alert("U moet een extra opmerking schrijven ", "geen extra opmerking", "ok");
            }
            else if (Vera && Photos.Count == 0)
            {
                UserDialogs.Instance.Alert("U moet zeker 1 foto nemen ", "foto vera", "ok");
            }
            else
            {

                await MessengerInstance.PublishAsync(new InspectionCompleteMessage(EquipmentId, InspectionResult.NotOk, FeedbackType, Remarks, Vera, Photos, Weight), CancellationToken.None);
                await NavigationService.RemovePage<IEquipmentDetailPage>();
                await NavigationService.PopAsync();
            }
        }

        private async Task CancelAsync()
        {
            await NavigationService.PopAsync();
        }

        /**
         * this handel the delete of the picture
         */
        public Task HandleAsync(DeletePhotoMessage message, CancellationToken cancellationToken)
        {
            sLogger.DeletingAPhoto();
            Photos.Remove(message.PhotoToDelete);
            GetService<IFileSystemService>().DeleteFile(message.PhotoToDelete.Path);
            return Task.CompletedTask;
        }

        public Task PoppedAsync()
        {
            MessengerInstance.Unsubscribe(this);
            return Task.CompletedTask;
        }

        public Task PushedAsync()
        {
            MessengerInstance.Subscribe(this);
            return Task.CompletedTask;
        }
    }
}



