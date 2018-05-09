using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{


    public class NavigationRemovePageMessage<TPageView> : INavigationCommand
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

        public NavigationRemovePageMessage(Action<TPageView> callback = null)
        {
            Callback = callback;
        }

        Task INavigationCommand.ExecuteAsync(INavigation navigation, IPageResolver pageResolver)
        {
            var page = navigation.NavigationStack.LastOrDefault((p) => p is TPageView);
            if (page != null)
            {
                navigation.RemovePage(page);
            }
            return Task.CompletedTask;
        }

    }
}

