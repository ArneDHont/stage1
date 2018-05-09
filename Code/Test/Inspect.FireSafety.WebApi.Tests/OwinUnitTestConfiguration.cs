using AutoMapper;
using Inspect.WebApi.Host.Configuration;
using Owin;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Unity;

namespace Inspect.FireSafety.WebApi
{
    public class OwinUnitTestConfiguration
    {
        private IUnityContainer mContainer;

        public OwinUnitTestConfiguration(IUnityContainer container)
        {
            mContainer = container;
        }

        public void Configuration(IAppBuilder app)
        {
            IUnityContainer container = new UnityContainer();
            HttpConfiguration config = new HttpConfiguration();
            HttpServer server = new HttpServer(config);

            WebApiConfig.Register(config, server);
            FireSafetyConfig.Register(config);

            config.Services.Replace(typeof(IAssembliesResolver), new UnitTestAssembliesResolver());
            // Use Unity in UnitTests
            config.DependencyResolver = new UnityDependencyResolver(mContainer);

            app.UseWebApi(config);

            Mapper.Reset();
            Mapper.Initialize(cfg =>
            {
                FireSafetyConfig.ConfigureMapper(cfg);
            });
        }

        internal class UnitTestAssembliesResolver : DefaultAssembliesResolver
        {
            public override ICollection<Assembly> GetAssemblies()
            {
                return new List<Assembly> { typeof(FireSafetyConfig).Assembly };
            }
        }
    }
}