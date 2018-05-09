using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Unity;
using Unity.Exceptions;

namespace Inspect.WebApi.Host.Configuration
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer mContainer;

        public UnityDependencyResolver(IUnityContainer container)
        {
            mContainer = container;
        }

        public IDependencyScope BeginScope()
        {
            var child = mContainer.CreateChildContainer();
            return new UnityDependencyResolver(child);
        }

        public void Dispose()
        {
            mContainer.Dispose();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return mContainer.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return mContainer.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return Enumerable.Empty<object>();
            }
        }
    }
}