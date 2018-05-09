using Inspect.Framework.Hypermedia;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace Inspect.WebApi.Host.Configuration
{
    /// <summary>
    /// Exception filter responsible for converting a SQL Error 547 into a Http 409 - Conflict when deleting a resource.
    /// </summary>
    public class DeleteConflictsWithReferenceConstraintExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Request.Method == HttpMethod.Delete && actionExecutedContext.Exception is DbUpdateException)
            {
                if (actionExecutedContext.Exception.GetBaseException() is SqlException sqlException && sqlException.Number == 547)
                {
                    var newResponse = actionExecutedContext.Request.CreateResponse((HttpStatusCode.Conflict), new ConflictRepresentation() { Reason = Resources.Strings.DeleteConflictsWithReferenceConstraintExceptionFilterAttribute_Reason });
                }
            }
        }
    }
}