using System;

namespace Inspect.Framework.Logging
{
    public static class LogEvents
    {
        public static void ExceptionOccured(this ILogger logger, Exception ex)
        {
            var logEvent = new LogEvent(101, Level.Error, "Exception occured during runtime, see exception details for more information", ex);
            logger.Log(logEvent);
        }
    }
}