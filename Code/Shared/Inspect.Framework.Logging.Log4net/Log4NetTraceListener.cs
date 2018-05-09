using System;
using System.Diagnostics;
using System.Reflection;

namespace Inspect.Framework.Logging.Log4net
{
    public class Log4NetTraceListener : TraceListener
    {
        private ILogger mLogger;

        public override void Write(string message)
        {
            EnsureLogger();
            var logEvent = LogEvent.Create(0, Level.Trace, message);
            mLogger.Log(logEvent);
        }

        public override void WriteLine(string message)
        {
            EnsureLogger();
            var logEvent = LogEvent.Create(0, Level.Trace, message);
            mLogger.Log(logEvent);
        }

        private void EnsureLogger()
        {
            if (mLogger == null)
            {
                mLogger = LogManager.GetLogger(this.Name);
            }
        }
    }
}