using System;

namespace Inspect.Mobile.Framework.Xamarin.Logging
{
    public static class LogEvents
    {
        public static void ExceptionOccured(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Error, "Exception occured during runtime, see exception details for more information", ex);
            logger.Log(logEvent);
        }
    }
}