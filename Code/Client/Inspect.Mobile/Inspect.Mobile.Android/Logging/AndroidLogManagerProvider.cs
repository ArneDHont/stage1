using Inspect.Mobile.Droid.Logging;
using Inspect.Mobile.Framework.Xamarin.Logging;
using System;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidLogManagerProvider))]

namespace Inspect.Mobile.Droid.Logging
{
    public class AndroidLogManagerProvider : ILogManagerProvider
    {
        public void Configure()
        {
        }

        public ILogger GetLogger(Type type)
        {
            return new AndroidLogger(tag: "Inspect.Mobile");
        }
    }
}