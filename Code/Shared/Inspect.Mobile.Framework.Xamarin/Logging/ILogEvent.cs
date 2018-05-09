using System;

namespace Inspect.Mobile.Framework.Xamarin.Logging
{
    public interface ILogEvent
    {
        Exception Exception { get; }

        int InstanceId { get; }

        Level Level { get; }

        string Message { get; }
    }
}