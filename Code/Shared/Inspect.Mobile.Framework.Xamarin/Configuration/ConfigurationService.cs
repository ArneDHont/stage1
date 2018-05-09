using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Inspect.Mobile.Framework.Xamarin.Configuration
{
    public static class ConfigurationService
    {
        private static ConfigurationServiceProvider sCurrentProvider = () => new DefaultValueConfigurationService();

        public static IConfigurationService Current
        {
            get { return sCurrentProvider(); }
        }

        public static void SetProvider(ConfigurationServiceProvider provider)
        {
            sCurrentProvider = provider;
        }

        private class DefaultValueConfigurationService : IConfigurationService
        {
            public TApplicationConfiguration Read<TApplicationConfiguration>() where TApplicationConfiguration : new()
            {
               return new TApplicationConfiguration();
            }
        }
    }
}
