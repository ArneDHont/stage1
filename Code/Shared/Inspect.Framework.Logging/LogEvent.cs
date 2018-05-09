using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.Framework.Logging
{
    public class LogEvent : ILogEvent
    {
        public LogEvent(int instanceId, Level level, string message, Exception exception = null)
        {
            if (instanceId < short.MinValue || instanceId > short.MaxValue)
            {
                throw new ArgumentOutOfRangeException("instanceId", "instanceId should be a short.");
            }

            this.Level = level;
            this.InstanceId = instanceId;
            this.Message = message ?? throw new ArgumentNullException(nameof(message));
            this.Exception = exception;
        }

        public Exception Exception { get; private set; }

        public int InstanceId { get; private set; }

        public Level Level { get; private set; }

        public string Message { get; private set; }

        public static ILogEvent Create(int instanceId, Level level, string message, Exception exception = null)
        {
            return new LogEvent(instanceId, level, message, exception);
        }

        public static ILogEvent Create(int instanceId, Level level, Func<string> producer, Exception exception = null)
        {
            return new LogEventProducer(instanceId, level, producer, exception);
        }
    }
}
