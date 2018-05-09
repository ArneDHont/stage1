using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public class NavigationCommandHandler : IHandleAsync<INavigationCommand>
    {
        private INavigation mNavigation;

        private IPageResolver mPageResolver;

        public NavigationCommandHandler(INavigation navigation, IPageResolver pageResolver)
        {
            mNavigation = navigation;
            mPageResolver = pageResolver;
        }

        public Task HandleAsync(INavigationCommand message, CancellationToken cancellationToken)
        {
            return message.ExecuteAsync(mNavigation, mPageResolver);
        }
    }
}