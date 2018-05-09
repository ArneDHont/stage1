using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public interface IPageResolver
    {
        Page GetPage<TPageView>() where TPageView : IPageView;
    }
}