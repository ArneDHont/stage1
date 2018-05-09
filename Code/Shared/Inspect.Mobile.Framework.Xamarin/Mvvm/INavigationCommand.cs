using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public interface INavigationCommand
    {
        Task ExecuteAsync(INavigation navigation, IPageResolver pageResolver);
    }
}