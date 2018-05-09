using System;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public interface IServiceProviderCommand
    {
        void Execute(IServiceProvider serviceProvider);
    }
}