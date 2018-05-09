namespace Inspect.Mobile.Framework.Xamarin.ComponentModel
{
    public interface ICanRaisePropertyChanged
    {
        void RaisePropertyChanged(string propertyName = null);
    }
}