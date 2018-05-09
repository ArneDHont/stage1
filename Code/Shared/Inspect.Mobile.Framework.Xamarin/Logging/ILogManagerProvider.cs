using System;

namespace Inspect.Mobile.Framework.Xamarin.Logging
{
    public interface ILogManagerProvider
    {
        void Configure();

        ILogger GetLogger(Type type);
    }
}