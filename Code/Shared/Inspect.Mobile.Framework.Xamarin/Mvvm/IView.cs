using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public interface IView
    {
        ResourceDictionary Resources { get; }
    }

    public static class ViewExtensions
    {
        public const string ViewModelKey = "ViewModel";

        public static object GetViewModelFromResources(this IView view)
        {
            return view.Resources[ViewModelKey];
        }

        public static TViewModel GetViewModelFromResources<TViewModel>(this IView view)
        {
            return (TViewModel)GetViewModelFromResources(view);
        }
    }
}