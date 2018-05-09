using Inspect.Framework.Hypermedia;
using System.Net.Http;
using System.Web.Http.Filters;


namespace Inspect.WebApi.Host.Configuration
{
    public class HypermediaActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            string actionName = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;

            if (actionExecutedContext.ActionContext.ControllerContext.Controller is IHypermediaController hypermediaController && actionExecutedContext.Response != null)
            {
                if (actionExecutedContext.Response.TryGetContentValue(out object content) && content is Representation)
                {
                    hypermediaController.Hypermedia.ProcessAction(actionName, (Representation)content);
                }
            }
        }
    }
}