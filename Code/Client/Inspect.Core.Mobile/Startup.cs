using Inspect.Core.Mobile.NetworkStatus;
using Unity;

namespace Inspect.Core.Mobile
{
    public static class Startup
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<INetworkStatusPage, NetworkStatusPage>();
        }
    }
}