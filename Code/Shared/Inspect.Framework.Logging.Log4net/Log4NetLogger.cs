using log4net;
using System;

namespace Inspect.Framework.Logging.Log4net
{
    public class Log4NetLogger : ILogger
    {
        private ILog mUnderlyingLogger;

        public Log4NetLogger(ILog underlyingLogger)
        {
            mUnderlyingLogger = underlyingLogger ?? throw new ArgumentNullException(nameof(underlyingLogger));
        }

        public void Log(ILogEvent logEvent)
        {
            global::log4net.Core.LoggingEvent loggingEvent = new global::log4net.Core.LoggingEvent(typeof(Log4NetLogger), mUnderlyingLogger.Logger.Repository, mUnderlyingLogger.Logger.Name, TranslateToLog4Net(logEvent.Level), logEvent.Message, logEvent.Exception);
            loggingEvent.Properties["EventID"] = logEvent.InstanceId;
            mUnderlyingLogger.Logger.Log(loggingEvent);
        }

        private static global::log4net.Core.Level TranslateToLog4Net(Level level)
        {
            if (level == Level.All)
            {
                return global::log4net.Core.Level.All;
            }
            else if (level == Level.Trace)
            {
                return global::log4net.Core.Level.Trace;
            }
            else if (level == Level.Info)
            {
                return global::log4net.Core.Level.Info;
            }
            else if (level == Level.Debug)
            {
                return global::log4net.Core.Level.Debug;
            }
            else if (level == Level.Warn)
            {
                return global::log4net.Core.Level.Warn;
            }
            else if (level == Level.Error)
            {
                return global::log4net.Core.Level.Error;
            }
            else if (level == Level.Fatal)
            {
                return global::log4net.Core.Level.Fatal;
            }
            else
            {
                return global::log4net.Core.Level.Off;
            }
        }
    }
}