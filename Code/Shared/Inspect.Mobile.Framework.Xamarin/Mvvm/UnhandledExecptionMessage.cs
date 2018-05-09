using System;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public class UnhandledExecptionMessage
    {
        public Exception Exception { get; set; }

        public UnhandledExecptionMessage(Exception exception)
        {
            this.Exception = exception;
        }

        public static UnhandledExecptionMessage New(Exception exception)
        {
            return new UnhandledExecptionMessage(exception);
        }
    }
}