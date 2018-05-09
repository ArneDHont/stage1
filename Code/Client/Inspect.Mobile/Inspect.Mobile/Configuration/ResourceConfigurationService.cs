using Inspect.Mobile.Framework.Xamarin.Configuration;
using Inspect.Mobile.Framework.Xamarin.Logging;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Inspect.Mobile.Configuration
{
    public class ResourceConfigurationService : IConfigurationService
    {
        private static readonly ILogger sLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static Assembly sAssembly = typeof(ResourceConfigurationService).Assembly;

        private string mResourceName;

        public ResourceConfigurationService(string name = "App.config")
        {
            var assembly = typeof(ResourceConfigurationService).Assembly;
            if (!assembly.GetManifestResourceNames().Contains(name))
            {
                throw new ArgumentException($"Emedded resource '{name}' was not found in assembly '{sAssembly.FullName}'");
            }

            mResourceName = name;
        }

        public TApplicationConfiguration Read<TApplicationConfiguration>() where TApplicationConfiguration : new()
        {
            string type = typeof(TApplicationConfiguration).Name;
            ConfigurationValue[] configurationValues = GetConfigurationValueElementsForType(type);
            sLogger.ConfigurationValuesForTypeRead(type, configurationValues.Length);

            var element = new XElement(type);
            foreach (var c in configurationValues)
            {
                sLogger.ConfigurationValueRead(type, c.Name, c.Value);
                element.SetElementValue(c.Name, c.Value);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(TApplicationConfiguration));
            using (XmlReader reader = element.CreateReader())
            {
                try
                {
                    return (TApplicationConfiguration)serializer.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    sLogger.ConfigurationDeserializedFailed(type, element, ex);
                    throw;
                }
            }
        }

        private ConfigurationValue[] GetConfigurationValueElementsForType(string type)
        {
            var assembly = typeof(ResourceConfigurationService).Assembly;

            ConfigurationValue[] configurationValues;
            using (Stream resourceStream = assembly.GetManifestResourceStream(mResourceName))
            {
                configurationValues = XDocument.Load(resourceStream).Element("configuration")
                    .Elements("value").Where(x => x.Attribute("type").Value == type)
                    .Select(x => new ConfigurationValue() { Name = x.Attribute("name").Value, Value = x.Attribute("value").Value })
                    .ToArray();
            }
            return configurationValues;
        }

        private Stream GetManifestResourceStream(string name, bool ignoreCase = true)
        {
            var resourceName = sAssembly.GetManifestResourceNames().FirstOrDefault(x => string.Compare(x, name, ignoreCase) == 0);
            return sAssembly.GetManifestResourceStream(resourceName ?? name);
        }

        private class ConfigurationValue
        {
            public string Name { get; set; }

            public string Value { get; set; }
        }
    }
}