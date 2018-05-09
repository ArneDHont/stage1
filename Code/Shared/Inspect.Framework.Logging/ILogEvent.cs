using System;

namespace Inspect.Framework.Logging
{
    public interface ILogEvent
    {
        Exception Exception { get; }

        int InstanceId { get; }

        Level Level { get; }

        string Message { get; }
    }
}