using Android.Util;
using Inspect.Mobile.Framework.Xamarin.Logging;
using Java.Lang;
using System;

namespace Inspect.Mobile.Droid.Logging
{
    public class AndroidLogger : ILogger
    {
        public string Tag { get; private set; }

        public AndroidLogger(string tag)
        {
            Tag = tag;
        }

        public void Log(ILogEvent logEvent)
        {
            LogPriority priority = TranslateToAndroidPriority(logEvent.Level);
            Throwable throwable = null;

            if (logEvent.Exception != null)
            {
                throwable = Throwable.FromException(logEvent.Exception);
            }

            if (Android.Util.Log.IsLoggable(Tag, priority))
            {
                if (logEvent.Level == Level.Error)
                {
                    Error(logEvent.Message, throwable);
                }
                else if (logEvent.Level == Level.Debug)
                {
                    Debug(logEvent.Message, throwable);
                }
                else if (logEvent.Level == Level.Info)
                {
                    Info(logEvent.Message, throwable);
                }
                else if (logEvent.Level == Level.Trace)
                {
                    Verbose(logEvent.Message, throwable);
                }
                else if (logEvent.Level == Level.Warn)
                {
                    Warn(logEvent.Message, throwable);
                }
                else if (logEvent.Level == Level.Fatal)
                {
                    Wtf(logEvent.Message, throwable);
                }
            }
        }

        private void Debug(string message, Throwable throwable = null)
        {
            if (throwable == null)
            {
                Android.Util.Log.Debug(Tag, message);
            }
            else
            {
                Android.Util.Log.Debug(Tag, throwable, message);
            }
        }

        private void Error(string message, Throwable throwable = null)
        {
            if (throwable == null)
            {
                Android.Util.Log.Error(Tag, message);
            }
            else
            {
                Android.Util.Log.Error(Tag, throwable, message);
            }
        }

        private void Info(string message, Throwable throwable = null)
        {
            if (throwable == null)
            {
                Android.Util.Log.Info(Tag, message);
            }
            else
            {
                Android.Util.Log.Info(Tag, throwable, message);
            }
        }

        private LogPriority TranslateToAndroidPriority(Level level)
        {
            if (level == Level.All || level == Level.Trace)
            {
                return LogPriority.Verbose;
            }
            else if (level == Level.Info)
            {
                return LogPriority.Info;
            }
            else if (level == Level.Debug)
            {
                return LogPriority.Debug;
            }
            else if (level == Level.Warn)
            {
                return LogPriority.Warn;
            }
            else if (level == Level.Error)
            {
                return LogPriority.Error;
            }
            else
            {
                return LogPriority.Assert;
            }
        }

        private void Verbose(string message, Throwable throwable = null)
        {
            if (throwable == null)
            {
                Android.Util.Log.Verbose(Tag, message);
            }
            else
            {
                Android.Util.Log.Verbose(Tag, throwable, message);
            }
        }

        private void Warn(string message, Throwable throwable = null)
        {
            if (throwable == null)
            {
                Android.Util.Log.Warn(Tag, message);
            }
            else
            {
                Android.Util.Log.Warn(Tag, throwable, message);
            }
        }

        private void Wtf(string message, Throwable throwable = null)
        {
            if (throwable == null)
            {
                Android.Util.Log.Wtf(Tag, message);
            }
            else
            {
                Android.Util.Log.Wtf(Tag, throwable, message);
            }
        }
    }
}