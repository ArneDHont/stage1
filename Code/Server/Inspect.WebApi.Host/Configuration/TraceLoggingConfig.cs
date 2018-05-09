using System.Diagnostics;
using System.Web.Http;

namespace Inspect.WebApi.Host.Configuration
{
    public static class TraceLoggingConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.EnableSystemDiagnosticsTracing();
        }
    }
}