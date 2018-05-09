using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspect.Core.Mobile.NetworkStatus
{
    public interface INetworkStatusPage : IPageView
    {
        NetworkStatusViewModel ViewModel { get; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NetworkStatusPage : ContentPage, INetworkStatusPage
    {
        public NetworkStatusPage()
        {
            InitializeComponent();
        }

        public NetworkStatusViewModel ViewModel
        {
            get
            {
                return this.GetViewModelFromResources<NetworkStatusViewModel>();
            }
        }
    }
}