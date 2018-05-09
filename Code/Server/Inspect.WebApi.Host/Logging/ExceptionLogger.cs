using Inspect.Framework.Logging;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace Inspect.WebApi.Host.Logging
{
    public class ExceptionLogger : IExceptionLogger
    {
        private static readonly ILogger sLogger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            sLogger.ExceptionOccured(context.Exception);
            return Task.WhenAll();
        }
    }
}