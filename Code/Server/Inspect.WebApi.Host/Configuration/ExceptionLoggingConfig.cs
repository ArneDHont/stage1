using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace Inspect.WebApi.Host.Configuration
{
    public static class ExceptionLoggingConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Services.Replace(typeof(IExceptionLogger), new Logging.ExceptionLogger());
        }
    }
}