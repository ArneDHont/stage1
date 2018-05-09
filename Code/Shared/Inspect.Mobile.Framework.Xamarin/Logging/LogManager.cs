using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.Mobile.Framework.Xamarin.Logging
{
    public class LogManager
    {
        private static LogManagerProvider mCurrentProvider = () => new NullLogManagerProvider();

        public static void SetProvider(LogManagerProvider provider)
        {
            mCurrentProvider = provider;
        }

        public static void Configure()
        {
            mCurrentProvider.Invoke().Configure();
        }

        public static ILogger GetLogger(Type type)
        {
            return mCurrentProvider.Invoke().GetLogger(type);
        }

        private class NullEventLogger : ILogger
        {
            public void Log(ILogEvent logEvent)
            {
            }
        }

        private class NullLogManagerProvider : ILogManagerProvider
        {
            public void Configure()
            {
            }

            public ILogger GetLogger(Type type)
            {
                return new NullEventLogger();
            }
        }
    }
}
