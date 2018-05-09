using System;

namespace Inspect.Mobile.Framework.Xamarin.Logging
{
    public class LogEvent : ILogEvent
    {
        public LogEvent(int instanceId, Level level, string message, Exception exception = null)
        {
            if (instanceId < short.MinValue || instanceId > short.MaxValue)
            {
                throw new ArgumentOutOfRangeException("instanceId", "instanceId should be a short.");
            }

            Level = level;
            InstanceId = instanceId;
            Message = message ?? throw new ArgumentNullException(nameof(message));
            Exception = exception;
        }

        public Exception Exception { get; private set; }

        public int InstanceId { get; private set; }

        public Level Level { get; private set; }

        public string Message { get; private set; }

        public static ILogEvent Create(int instanceId, Level level, string message, Exception exception = null)
        {
            return new LogEvent(instanceId, level, message, exception);
        }

        public static ILogEvent Create(Level level, string message, Exception exception = null)
        {
            return new LogEvent(0, level, message, exception);
        }

        public static ILogEvent Create(int instanceId, Level level, Func<string> producer, Exception exception = null)
        {
            return new LogEventProducer(instanceId, level, producer, exception);
        }

        public static ILogEvent Create(Level level, Func<string> producer, Exception exception = null)
        {
            return new LogEventProducer(0, level, producer, exception);
        }
    }
}