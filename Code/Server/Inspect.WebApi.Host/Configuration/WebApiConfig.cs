using FluentValidation.WebApi;
using Inspect.Framework.Hypermedia.Json;
using Newtonsoft.Json;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Batch;
using System.Web.Http.Cors;
using System.Web.Http.Dispatcher;
using System.Web.Http.Validation;
using System.Web.Http.ValueProviders;
using System.Web.Http.ValueProviders.Providers;

namespace Inspect.WebApi.Host.Configuration
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config, HttpServer server)
        {
            // Flowing line should only be used in an intanet environment.
            config.EnableCors(new EnableCorsAttribute("*", "*", "*") { SupportsCredentials = true });

            // Remove "Controller" suffix.
            // Taken from http://www.strathweb.com/2013/02/but-i-dont-want-to-call-web-api-controllers-controller/
            var suffix = typeof(DefaultHttpControllerSelector).GetField(nameof(DefaultHttpControllerSelector.ControllerSuffix), BindingFlags.Static | BindingFlags.Public);
            if (suffix != null) suffix.SetValue(null, string.Empty);

            // Inject custom services
            config.Services.Replace(typeof(IHttpControllerTypeResolver), new HttpServiceTypeResolver());

            //Allow Kebab casing in QueryString keys
            var queryStringValueProviderFactory = config.Services.GetValueProviderFactories().FirstOrDefault(x => x is QueryStringValueProviderFactory);
            if (queryStringValueProviderFactory != null)
            {
                config.Services.Remove(typeof(ValueProviderFactory), queryStringValueProviderFactory);
            }
            config.Services.Insert(typeof(ValueProviderFactory), 0, new KebabToPascalCaseQueryStringValueProviderFactory());

            // Filter that transforms the response to a BadRequest when the model is not valid.
            config.Filters.Add(new ValidateModelStateFilterAttribute());
            // Filter that transforms the response to a Conflict when reference constraint exception occurs.
            config.Filters.Add(new DeleteConflictsWithReferenceConstraintExceptionFilterAttribute());
            // Filter that include hypermedia based on the action name.
            config.Filters.Add(new HypermediaActionFilterAttribute());

            // Message handlers that convert HttpErrors to an Unprocessable Entity response.
            config.MessageHandlers.Add(new UnprocessableEntityResponseHandler());
            // Message handler that adds a self reference to the representation when it is empty.
            config.MessageHandlers.Add(new HypermediaResponseHandler());
            // Map the routes based on the attributes.
            config.MapHttpAttributeRoutes();
            // Map the route that allows batch requests.
            config.Routes.MapHttpBatchRoute(
                routeName: "batch",
                routeTemplate: "api/batch",
                batchHandler: new DefaultHttpBatchHandler(server)
            );

            // Disable XmlFormatter because we are only using json.
            config.Formatters.Add(new FormMultipartRelatedMediaTypeFormatter(config));
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            // Configure Json serializer
            var jsonFormatter = config.Formatters.JsonFormatter;
            jsonFormatter.UseDataContractJsonSerializer = false;
            var settings = jsonFormatter.SerializerSettings;
            settings.TypeNameHandling = TypeNameHandling.Auto;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new KebabCasePropertyNamesContractResolver();
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.None;

            // Configure FluentValidation
            FluentValidationModelValidatorProvider.Configure(config);
            // It is imported to replace the IBodyModelValidator after the FluentValidation changed it by its own implementation.
            config.Services.Replace(typeof(IBodyModelValidator), new PrefixlessBodyModelValidator(config.Services.GetBodyModelValidator()));
        }
    }
}