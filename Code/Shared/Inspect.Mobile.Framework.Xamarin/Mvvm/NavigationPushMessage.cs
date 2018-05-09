using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public class NavigationPushMessage<TPageView> : INavigationCommand
        where TPageView : IPageView
    {
        public Type ViewType
        {
            get
            {
                return typeof(TPageView);
            }
        }

        public Action<TPageView> Callback { get; private set; }

        public NavigationPushMessage(Action<TPageView> callback = null)
        {
            Callback = callback;
        }

        async Task INavigationCommand.ExecuteAsync(INavigation navigation, IPageResolver pageResolver)
        {
            var page = pageResolver.GetPage<TPageView>();
            await navigation.PushAsync(page);

            object callbackParmeter = page;
            if (callbackParmeter is TPageView)
            {
                Callback?.Invoke((TPageView)callbackParmeter);
            }
        }
    }
}