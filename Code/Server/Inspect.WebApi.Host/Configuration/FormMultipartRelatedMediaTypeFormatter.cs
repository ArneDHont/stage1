using Inspect.Framework.Hypermedia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using System.Web.Http.ModelBinding.Binders;
using System.Web.Http.ValueProviders.Providers;

namespace Inspect.WebApi.Host.Configuration
{
    /// <summary>
    /// A media type formatter that can format a multipart/related media type to a <see cref="Upload{TMetadata}"/> object.
    /// </summary>
    public class FormMultipartRelatedMediaTypeFormatter : MediaTypeFormatter
    {
        private const string SupportedMediaType = "multipart/related";

        private HttpConfiguration mConfiguration;

        public FormMultipartRelatedMediaTypeFormatter(HttpConfiguration configuration)
        {
            mConfiguration = configuration;
            SupportedMediaTypes.Add(new MediaTypeHeaderValue(SupportedMediaType));
        }

        public override bool CanReadType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Upload<>);
        }

        public override bool CanWriteType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            return false;
        }

        public override async Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (readStream == null)
            {
                throw new ArgumentNullException(nameof(readStream));
            }

            // load multipart related data into memory
            var provider = await content.ReadAsMultipartAsync(new MultipartRelatedStreamProvider());
            // fill parts into a dictionary for binding to model
            var modelDictionary = await ToModelDictionaryAsync(provider, type.GetGenericArguments()[0]);
            // bind the data to model
            return BindToModel(modelDictionary, type, formatterLogger);
        }

        private object BindToModel(IDictionary<string, object> data, Type type, IFormatterLogger formatterLogger)
        {
            // create a action context for model binding
            var actionContext = new HttpActionContext
            {
                ControllerContext = new HttpControllerContext
                {
                    Configuration = mConfiguration,
                    ControllerDescriptor = new HttpControllerDescriptor
                    {
                        Configuration = mConfiguration
                    }
                }
            };

            // create model binder context
            var valueProvider = new NameValuePairsValueProvider(data, CultureInfo.InvariantCulture);
            var metadataProvider = mConfiguration.Services.GetModelMetadataProvider();
            var metadata = metadataProvider.GetMetadataForType(null, type);
            var modelBindingContext = new ModelBindingContext()
            {
                ModelName = string.Empty,
                FallbackToEmptyPrefix = false,
                ModelMetadata = metadata,
                ModelState = actionContext.ModelState,
                ValueProvider = valueProvider
            };

            // bind model
            var modelBinderProvider = new CompositeModelBinderProvider(mConfiguration.Services.GetModelBinderProviders());
            var binder = modelBinderProvider.GetBinder(mConfiguration, type);
            var haveResult = binder.BindModel(actionContext, modelBindingContext);

            // log validation errors
            if (formatterLogger != null)
            {
                foreach (var modelStatePair in actionContext.ModelState)
                {
                    foreach (var modelError in modelStatePair.Value.Errors)
                    {
                        if (modelError.Exception != null)
                        {
                            formatterLogger.LogError(modelStatePair.Key, modelError.Exception);
                        }
                        else
                        {
                            formatterLogger.LogError(modelStatePair.Key, modelError.ErrorMessage);
                        }
                    }
                }
            }
            return haveResult ? modelBindingContext.Model : GetDefaultValueForType(type);
        }

        private async Task<Stream> ReadInputStreamFromProviderAsync(MultipartRelatedStreamProvider provider)
        {
            Stream stream = null;
            try
            {
                stream = await provider.Contents[1].ReadAsStreamAsync();
            }
            catch { }
            return stream;
        }

        private async Task<object> ReadMetadataFromProviderAsync(MultipartRelatedStreamProvider provider, Type metadataType)
        {
            object metadata = null;
            try
            {
                string jsonString = await provider.Contents[0].ReadAsStringAsync();
                metadata = JsonConvert.DeserializeObject(jsonString, metadataType, mConfiguration.Formatters.JsonFormatter.SerializerSettings);
            }
            catch { }
            return metadata;
        }

        private async Task<IDictionary<string, object>> ToModelDictionaryAsync(MultipartRelatedStreamProvider multipartProvider, Type metadataType)
        {
            var data = new Dictionary<string, object>();
            data[nameof(Upload<object>.Metadata)] = await ReadMetadataFromProviderAsync(multipartProvider, metadataType);
            data[nameof(Upload<object>.InputStream)] = await ReadInputStreamFromProviderAsync(multipartProvider);
            return data;
        }
    }
}