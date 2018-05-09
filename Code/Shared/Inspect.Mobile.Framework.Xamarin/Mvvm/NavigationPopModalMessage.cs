using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public class NavigationPopModalMessage : INavigationCommand
    {
        async Task INavigationCommand.ExecuteAsync(INavigation navigation, IPageResolver pageResolver)
        {
            await navigation.PopModalAsync();
        }
    }
}