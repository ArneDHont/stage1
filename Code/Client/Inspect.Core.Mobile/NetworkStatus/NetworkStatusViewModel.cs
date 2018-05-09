using Inspect.Mobile.Framework.Xamarin.Mvvm;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspect.Core.Mobile.NetworkStatus
{
    public class NetworkStatusViewModel : ViewModelBase, IAppearingAware, IDisappearingAware
    {
        private ICommand mNavigateCommand;

        public ICommand NavigateCommand
        {
            get
            {
                return mNavigateCommand ?? (mNavigateCommand = new Command(async () => await NaviateAsync()));
            }
        }

        public NetworkStatusViewModel()
        {
            Title = "Network";
        }

        public NetworkStatusViewModel(IMessenger messenger) : base(messenger)
        {
        }

        public async Task AppearingAsync()
        {
            Console.WriteLine("Appearing");
            try
            {
                IsBusy = true;
                await Task.Delay(3000);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public Task DisappearingAsync()
        {
            Console.WriteLine("Disappearing");
            return Task.CompletedTask;
        }

        public async Task NaviateAsync()
        {
            var page = await NavigationService.PushAsync<INetworkStatusPage>();
        }
    }
}