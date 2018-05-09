using Inspect.Mobile.Framework.Xamarin.Logging;
using System;
using System.Xml.Linq;

namespace Inspect.Mobile.Configuration
{
    public static class LogEvents
    {
        public static void ConfigurationValueRead(this ILogger logger, string type, string name, string value)
        {
            var logEvent = LogEvent.Create(Level.Debug, $"Configuration value read -  '{type}.{name}' = '{value}'");
            logger.Log(logEvent);
        }

        public static void ConfigurationDeserializedFailed(this ILogger logger, string type, XElement element, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Error, $"Deserialization of '{type}' failed for element {element.ToString()}, see exception details for more information", ex);
            logger.Log(logEvent);
        }

        public static void ConfigurationValuesForTypeRead(this ILogger logger, string type, int numberOfConfiguraionValues)
        {
            var logEvent = LogEvent.Create(Level.Debug, $"The number of ConfigurationValues that have been read for '{type}' is {numberOfConfiguraionValues}.");
            logger.Log(logEvent);
        }
    }
}