using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public interface INavigationService 
    {
        Task PopAsync();

        Task PopModalAsync();

        Task<TPageView> PushAsync<TPageView>() where TPageView : IPageView;

        Task<TPageView> PushModalAsync<TPageView>() where TPageView : IPageView;

        Task PopToRootAsync();
        Task<TPageView> RemovePage<TPageView>() where TPageView : IPageView;
    }
}