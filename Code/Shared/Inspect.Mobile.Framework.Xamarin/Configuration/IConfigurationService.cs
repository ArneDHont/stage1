namespace Inspect.Mobile.Framework.Xamarin.Configuration
{
    public interface IConfigurationService
    {
        TApplicationConfiguration Read<TApplicationConfiguration>() where TApplicationConfiguration : new();
    }
}