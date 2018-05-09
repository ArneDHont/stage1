using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public class NavigationService : INavigationService
    {
        private IMessenger mMessenger;

        public NavigationService(IMessenger messenger)
        {
            mMessenger = messenger;
        }

        public Task PopAsync()
        {
            return mMessenger.PublishAsync<INavigationCommand>(new NavigationPopMessage(), CancellationToken.None);
        }

        public Task PopModalAsync()
        {
            return mMessenger.PublishAsync<INavigationCommand>(new NavigationPopModalMessage(), CancellationToken.None);
        }

        public Task PopToRootAsync()
        {
            return mMessenger.PublishAsync<INavigationCommand>(new NavigationPopToRootMessage(), CancellationToken.None);
        }

        public async Task<TPageView> PushAsync<TPageView>() where TPageView : IPageView
        {
            TPageView view = default(TPageView);
            var message = new NavigationPushMessage<TPageView>((v) => view = v);
            await mMessenger.PublishAsync<INavigationCommand>(message, CancellationToken.None);
            return view;
        }

        public async Task<TPageView> PushModalAsync<TPageView>() where TPageView : IPageView
        {
            TPageView view = default(TPageView);
            var message = new NavigationPushModalMessage<TPageView>((v) => view = v);
            await mMessenger.PublishAsync<INavigationCommand>(message, CancellationToken.None);
            return view;
        }

        public async Task<TPageView> RemovePage<TPageView>() where TPageView : IPageView
        {
            TPageView view = default(TPageView);
            var message = new NavigationRemovePageMessage<TPageView>((v) => view = v);
            await mMessenger.PublishAsync<INavigationCommand>(message, CancellationToken.None);
            return view;
        }
    }
}