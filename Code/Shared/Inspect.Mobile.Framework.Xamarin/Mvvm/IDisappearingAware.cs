using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public interface IDisappearingAware
    {
        Task DisappearingAsync();
    }
}