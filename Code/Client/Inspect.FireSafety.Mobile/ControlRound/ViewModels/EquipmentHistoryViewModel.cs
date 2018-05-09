using AutoMapper;
using Inspect.FireSafety.Mobile.ControlRound.Models;
using Inspect.FireSafety.WebApi.EquipmentFeedbacks;
using Inspect.FireSafety.WebApi.FeedbackTypes;
using Inspect.FireSafety.WebApi.Users;
using Inspect.Framework.Hypermedia;
using Inspect.Mobile.Framework.Xamarin.Logging;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspect.FireSafety.Mobile.ControlRound.ViewModels
{
    public class EquipmentHistoryViewModel : ViewModelBase
    {
        private static readonly ILogger sLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private bool listVisible = true;
        private bool labelVisible = false;
        private ICommand itemClickCommand;
        private long equipmentId;
        private IMapper mapper;
        private ObservableCollection<InspectionEquipmentFeedback> equipmentFeedbackItems;
        private Color backgroundColor = Color.Gray;
        private InspectionEquipmentFeedback oldItem;

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
        public long EquipmentId
        {
            get { return equipmentId; }
            set
            {
                equipmentId = value;
                new Command(async () => await GetEquipmentFeedbackAsync()).Execute(null);
            }
        }
        public ObservableCollection<InspectionEquipmentFeedback> EquipmentFeedbackItems
        {
            get { return equipmentFeedbackItems; }
            set
            {
                equipmentFeedbackItems = value;
                RaisePropertyChanged();
            }
        }
        public InspectionEquipmentFeedback SelectedItem { get; set; }
        public ICommand ItemClickCommand
        {
            get
            {
                return itemClickCommand ?? (itemClickCommand = new Command(() => HideOrShowDetails()));
            }

        }

        public EquipmentHistoryViewModel()
        {
            Title = "History";
        }

        /**
         *this gets the Equipment feedbacks. 
         */
        private async Task GetEquipmentFeedbackAsync()
        {
            try
            {
                var config = new MapperConfiguration(cfg =>
                            {
                                cfg.CreateMap<InspectionEquipmentFeedbackRepresentation, InspectionEquipmentFeedback>();
                                cfg.CreateMap<FeedbackTypeRepresentation, FeedbackTypeModel>();
                                cfg.CreateMap<UserRepresentation, UserModel>();
                            });
                mapper = config.CreateMapper();
                var response = await Client.GetEnsureAsync<CollectionRepresentation<InspectionEquipmentFeedbackRepresentation>>("fire-safety/equipment/" + EquipmentId + "/equipmentfeedback").ConfigureAwait(false);

                EquipmentFeedbackItems = new ObservableCollection<InspectionEquipmentFeedback>(new List<InspectionEquipmentFeedback>(mapper.Map<IEnumerable<InspectionEquipmentFeedback>>(response.Elements)));
                if (equipmentFeedbackItems.Count == 0)
                {
                    LabelVisible = true;
                    ListVisible = false;
                }
            }catch(Exception e)
            {
                sLogger.GetInspectionItemsFailed(e);
            }


        }

        /**
         *this shows or hide the extra information 
         */
        private void HideOrShowDetails()
        {
            if (oldItem == SelectedItem)
            {
                SelectedItem.IsVisible = !SelectedItem.IsVisible;
                Update(SelectedItem);
            }
            else
            {
                if (oldItem != null)
                {
                    oldItem.IsVisible = false;
                    Update(oldItem);
                }
                SelectedItem.IsVisible = true;
                Update(SelectedItem);
            }
            oldItem = SelectedItem;
        }

        /**
         * with this the show and hide can work 
         */
        private void Update(InspectionEquipmentFeedback item)
        {
            var index = EquipmentFeedbackItems.IndexOf(item);
            EquipmentFeedbackItems.Remove(item);
            EquipmentFeedbackItems.Insert(index, item);
        }
    }
}
