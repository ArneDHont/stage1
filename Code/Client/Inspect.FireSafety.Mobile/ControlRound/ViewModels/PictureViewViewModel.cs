using Inspect.FireSafety.Mobile.ControlRound.Models;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspect.FireSafety.Mobile.ControlRound.ViewModels
{
    public class PictureViewViewModel : ViewModelBase
    {
        private ICommand okCommand;
        private ICommand deleteCommand;
        private MediaFile photo;

        public ICommand OkCommand
        {
            get { return okCommand ?? (okCommand = new Command(async () => await OkAsync())); }
        }
        public ICommand DeleteCommand
        {
            get { return deleteCommand ?? (deleteCommand = new Command(async () => await DeleteAsync())); }
        }
        public MediaFile Photo
        {
            get { return photo; }
            set
            {

                photo = value;
                RaisePropertyChanged();
            }
        }

        public PictureViewViewModel()
        {

        }

        public async Task OkAsync()
        {
            await NavigationService.PopModalAsync();
        }

        /**
         *this send the delete message to the not ok page. 
         */
        private async Task DeleteAsync()
        {
            await MessengerInstance.PublishAsync(new DeletePhotoMessage(Photo), CancellationToken.None);
            await NavigationService.PopModalAsync();
        }
    }
}
