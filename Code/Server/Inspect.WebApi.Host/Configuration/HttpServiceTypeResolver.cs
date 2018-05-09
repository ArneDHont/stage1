using System;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace Inspect.WebApi.Host.Configuration
{
    /// <summary>
    /// Custom Controller Type Resolver to load only controllers from Rest.Services projects.
    /// </summary>
    public class HttpServiceTypeResolver : DefaultHttpControllerTypeResolver
    {
        public HttpServiceTypeResolver() : base(IsControllerType)
        {
        }

        internal static bool IsControllerType(Type controllerType)
        {
            if (controllerType == null)
            {
                throw new ArgumentNullException(nameof(controllerType));
            }

            bool isHttpController = typeof(IHttpController).IsAssignableFrom(controllerType);

            bool result = controllerType.IsClass && controllerType.IsVisible && !controllerType.IsAbstract &&
                            typeof(IHttpController).IsAssignableFrom(controllerType);
            return result;
        }
    }
}