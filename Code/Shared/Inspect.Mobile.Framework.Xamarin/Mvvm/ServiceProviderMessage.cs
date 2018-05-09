using System;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public class ServiceProviderMessage : IServiceProviderCommand
    {
        public Action<object> Callback { get; private set; }

        public Type Type { get; private set; }

        public ServiceProviderMessage(Type type, Action<object> callback)
        {
            Type = type;
            Callback = callback;
        }

        void IServiceProviderCommand.Execute(IServiceProvider serviceProvider)
        {
            var instance = serviceProvider.GetService(Type);
            Callback?.Invoke(instance);
        }
    }
}