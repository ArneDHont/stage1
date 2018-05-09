using AutoMapper;
using Inspect.FireSafety.WebApi;
using Inspect.Framework.Logging;
using Inspect.Framework.Logging.Log4net;
using Inspect.WebApi.Host.Configuration;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Unity;

[assembly: OwinStartup(typeof(Inspect.WebApi.Host.Startup))]

namespace Inspect.WebApi.Host
{
    public class Startup
    {
        public static HttpConfiguration HttpConfiguration { get; private set; }

        public static HttpServer HttpServer { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            IUnityContainer container = new UnityContainer();

            HttpConfiguration = new HttpConfiguration();
            HttpServer = new HttpServer(HttpConfiguration);

            LogManager.SetProvider(() => new Log4NetLogManagerProvider());
            LogManager.Configure();          

            ExceptionLoggingConfig.Register(HttpConfiguration);
            TraceLoggingConfig.Register(HttpConfiguration);

            WebApiConfig.Register(HttpConfiguration, HttpServer);

            FireSafetyConfig.Register(HttpConfiguration);

            Mapper.Initialize((config) =>
            {
                FireSafetyConfig.ConfigureMapper(config);
            });

            app.UseWebApi(HttpConfiguration);
        }
    }
}