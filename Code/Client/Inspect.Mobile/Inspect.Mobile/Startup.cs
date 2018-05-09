using Inspect.Mobile.Views;
using Unity;

namespace Inspect.Mobile
{
    public static class Startup
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            
            container.RegisterType<ILoginPage, LoginPage>();
            Core.Mobile.Startup.ConfigureContainer(container);
            FireSafety.Mobile.Startup.ConfigureContainer(container);
        }
    }
}