using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public class NavigationPopMessage : INavigationCommand
    {
        async Task INavigationCommand.ExecuteAsync(INavigation navigation, IPageResolver pageResolver)
        {
            await navigation.PopAsync();
            
            
        }
    }
}