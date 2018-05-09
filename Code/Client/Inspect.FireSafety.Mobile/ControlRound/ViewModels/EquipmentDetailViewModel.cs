using Acr.UserDialogs;
using Inspect.FireSafety.Mobile.ControlRound.Models;
using Inspect.FireSafety.Mobile.ControlRound.Views;
using Inspect.FireSafety.WebApi.Equipment;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspect.FireSafety.Mobile.ControlRound.ViewModels
{
    public class EquipmentDetailViewModel : ViewModelBase
    {

        private bool isCo2 = false;
        private ICommand editCommand;
        private bool isVisible;
        private InspectionItemModel selectedItem;
        private ICommand okCommand;
        private ICommand historyCommand;
        private ICommand notOkCommand;


        public bool IsCo2
        {
            get { return isCo2; }
            set
            {
                isCo2 = value;
                RaisePropertyChanged();
            }
        }
        public ICommand EditCommand
        {
            get
            {
                return editCommand;
            }
            set
            {
                editCommand = value;
                RaisePropertyChanged();
            }

        }
        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                RaisePropertyChanged();
            }
        }
        public double? Weight { get; set; }
        public InspectionItemModel SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                if (SelectedItem.Equipment.DateVisualInspection.Value.Date.Equals(DateTime.Now.Date)) IsVisible = false;
                else IsVisible = true;
                RaisePropertyChanged();
            }
        }
        public ICommand OkCommand
        {
            get { return okCommand ?? (okCommand = new Command(async () => await OkNavigateAsync())); }
        }
        public ICommand HistoryCommand
        {
            get { return historyCommand ?? (historyCommand = new Command(async () => await HistoryNavigateAsync())); }
        }
        public ICommand NotOkCommand
        {
            get { return notOkCommand ?? (notOkCommand = new Command(async () => await NotOkNavigateAsync())); }
        }

        /**
         * navigate to the History page
         */
        private async Task HistoryNavigateAsync()
        {
            var page = await NavigationService.PushAsync<IEquipmentHistoryPage>();
            page.ViewModel.EquipmentId = selectedItem.Equipment.EquipmentId;
        }
        
        /**
         * this navigate to the not ok page 
         */
        private async Task NotOkNavigateAsync()
        {
            var page = await NavigationService.PushAsync<INotOkPage>();
            page.ViewModel.EquipmentId = SelectedItem.Equipment.EquipmentId;
            page.ViewModel.SelectedType = SelectedItem.Equipment.EquipmentType;
            page.ViewModel.Weight = Weight;
        }

        /**
         *this send the ok message to the overview page 
         */
        private async Task OkNavigateAsync()
        {
            await MessengerInstance.PublishAsync(new InspectionCompleteMessage(selectedItem.Equipment.EquipmentId, Weight, InspectionResult.Ok), CancellationToken.None);
            await NavigationService.PopAsync();
        }
    }
}
