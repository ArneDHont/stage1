using AutoMapper;
using System.Web.Http;

namespace Inspect.FireSafety.WebApi
{
    public static class FireSafetyConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
        }

        public static void ConfigureMapper(IMapperConfigurationExpression config)
        {
            config.AddProfiles(typeof(FireSafetyConfig));
        }
    }
}