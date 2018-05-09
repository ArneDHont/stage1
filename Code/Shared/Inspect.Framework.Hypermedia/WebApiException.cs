using System;

namespace Inspect.Framework.Hypermedia
{
    public class WebApiException : Exception
    {
        public WebApiException(string message) : base(message)
        {
        }

        public WebApiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}