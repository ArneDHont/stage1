using System;

namespace Inspect.Framework.Logging
{
    public class LogEventProducer : ILogEvent
    {
        private Func<string> mMessageProducer;

        public LogEventProducer(int instanceId, Level level, Func<string> messageProducer, Exception exception = null)
        {
            if (instanceId < short.MinValue || instanceId > short.MaxValue)
            {
                throw new ArgumentOutOfRangeException("instanceId", "instanceId should be a short.");
            }

            Level = level;
            InstanceId = instanceId;
            mMessageProducer = messageProducer ?? throw new ArgumentNullException(nameof(messageProducer));
            Exception = exception;
        }

        public Exception Exception { get; private set; }

        public int InstanceId { get; private set; }

        public Level Level { get; private set; }

        public string Message
        {
            get
            {
                return mMessageProducer();
            }
        }
    }
}