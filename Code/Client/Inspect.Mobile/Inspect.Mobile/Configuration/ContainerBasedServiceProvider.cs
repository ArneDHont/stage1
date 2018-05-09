using Inspect.Mobile.Framework.Xamarin.Mvvm;
using System;
using Unity;

namespace Inspect.Mobile.Configuration
{
    public class ContainerBasedServiceProvider : IServiceProvider, IHandle<IServiceProviderCommand>
    {
        private IUnityContainer mContainer;

        public ContainerBasedServiceProvider(IUnityContainer container)
        {
            mContainer = container;
        }

        public object GetService(Type serviceType)
        {
            return mContainer.Resolve(serviceType);
        }

        public void Handle(IServiceProviderCommand message)
        {
            message.Execute(this);
        }
    }
}