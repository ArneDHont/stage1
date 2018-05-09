using Inspect.Framework.Hypermedia.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Framework.Hypermedia
{
    public class WebApiClient : IWebApiClient
    {
        private string mBaseUrl;

        private HttpClient mHttpClient;

        private Lazy<JsonSerializerSettings> mSettings;

        public WebApiClient(HttpClient httpClient) : this("http://localhost/", httpClient)
        {
        }

        public WebApiClient(string baseUrl, HttpClient httpClient)
        {
            this.mBaseUrl = baseUrl;
            this.mHttpClient = httpClient;
            this.mSettings = new Lazy<JsonSerializerSettings>(() =>
            {
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.Indented,
                    ContractResolver = new KebabCasePropertyNamesContractResolver()
                };
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }

        public string BaseUrl
        {
            get
            {
                return mBaseUrl;
            }
            set
            {
                mBaseUrl = value;
            }
        }

        public async Task<IWebApiResponse> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Delete;
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.RequestUri = GetAbsoluteUri(requestUri);

                using (HttpResponseMessage response = await mHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false))
                {
                    if (response.StatusCode == HttpStatusCode.Conflict)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        ConflictRepresentation result = default(ConflictRepresentation);
                        try
                        {
                            result = JsonConvert.DeserializeObject<ConflictRepresentation>(responseData, mSettings.Value);
                            return new ContentWebApiResponse<ConflictRepresentation>(response.StatusCode, response.ReasonPhrase, result);
                        }
                        catch (Exception exception)
                        {
                            throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Deserialize_Response_Content_Failed, typeof(ConflictRepresentation).Name), exception);
                        }
                    }
                    else if (response.StatusCode != HttpStatusCode.NoContent)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        return new ContentWebApiResponse<string>(response.StatusCode, response.ReasonPhrase, responseData);
                    }
                    else
                    {
                        return new WebApiResponse(response.StatusCode, response.ReasonPhrase);
                    }
                }
            }
        }

        public Uri GetAbsoluteUri(Uri relativeOrAbsoluteUri)
        {
            if (relativeOrAbsoluteUri.IsAbsoluteUri)
            {
                return relativeOrAbsoluteUri;
            }
            else
            {
                // The mBaseUrl must be the full URL to the api without a trailing slash e.g. http://localhost/InspectIt.WebApi.Host

                // Following lines all results in same uri (http://localhost/InspectIt.WebApi.Host/chemical-agents/campaigns)
                // http://localhost/InspectIt.WebApi.Host + "chemical-agents/campaigns"
                // http://localhost/InspectIt.WebApi.Host + "/InspectIt.WebApi.Host/chemical-agents/campaigns"

                // By appending a trailing slash to the mBaseUrl we get the expected behaviour.
                Uri baseUri = new Uri(!relativeOrAbsoluteUri.OriginalString.StartsWith("/") ? mBaseUrl + "/" : mBaseUrl);
                return new Uri(baseUri, relativeOrAbsoluteUri);
            }
        }

        public async Task<IWebApiResponse> GetAsync<TRepresentation>(Uri requestUri, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Get;
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.RequestUri = GetAbsoluteUri(requestUri);

                HttpResponseMessage response = await mHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        TRepresentation result = default(TRepresentation);
                        try
                        {
                            result = JsonConvert.DeserializeObject<TRepresentation>(responseData, mSettings.Value);
                            return new ContentWebApiResponse<TRepresentation>(response.StatusCode, response.ReasonPhrase, result);
                        }
                        catch (Exception exception)
                        {
                            throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Deserialize_Response_Content_Failed, typeof(TRepresentation).Name), exception);
                        }
                    }
                    else if (response.StatusCode != HttpStatusCode.NoContent)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        return new ContentWebApiResponse<string>(response.StatusCode, response.ReasonPhrase, responseData);
                    }
                    else
                    {
                        return new WebApiResponse(response.StatusCode, response.ReasonPhrase);
                    }
                }
                finally
                {
                    if (response != null)
                    {
                        response.Dispose();
                    }
                }
            }
        }

        public async Task<IWebApiResponse> GetStreamAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Get;
                request.RequestUri = GetAbsoluteUri(requestUri);

                HttpResponseMessage response = await mHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var responseData = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                        return new ContentWebApiResponse<Stream>(response.StatusCode, response.ReasonPhrase, responseData);
                    }
                    else
                    {
                        return new WebApiResponse(response.StatusCode, response.ReasonPhrase);
                    }
                }
                finally
                {
                    if (response != null)
                    {
                        response.Dispose();
                    }
                }
            }
        }

        public async Task<IWebApiResponse> OptionsAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Options;
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.RequestUri = GetAbsoluteUri(requestUri);

                HttpResponseMessage response = await mHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        OptionsRepresentation result = default(OptionsRepresentation);
                        try
                        {
                            result = JsonConvert.DeserializeObject<OptionsRepresentation>(responseData, mSettings.Value);
                            return new ContentWebApiResponse<OptionsRepresentation>(response.StatusCode, response.ReasonPhrase, result);
                        }
                        catch (Exception exception)
                        {
                            throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Deserialize_Response_Content_Failed, typeof(OptionsRepresentation).Name), exception);
                        }
                    }
                    else if (response.StatusCode != HttpStatusCode.NoContent)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        return new ContentWebApiResponse<string>(response.StatusCode, response.ReasonPhrase, responseData);
                    }
                    else
                    {
                        return new WebApiResponse(response.StatusCode, response.ReasonPhrase);
                    }
                }
                finally
                {
                    if (response != null)
                    {
                        response.Dispose();
                    }
                }
            }
        }

        public async Task<IWebApiResponse> PostAsync<TRepresentation>(Uri requestUri, TRepresentation representation, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.RequestUri = GetAbsoluteUri(requestUri);
                try
                {
                    var requestData = JsonConvert.SerializeObject(representation, mSettings.Value);
                    request.Content = new StringContent(requestData, Encoding.UTF8, "application/json");
                }
                catch (Exception exception)
                {
                    throw new WebApiException(Resources.Strings.WebApiClient_Serialize_Request_Content_Failed, exception);
                }

                HttpResponseMessage response = await mHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    if (response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NoContent)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        CreatedRepresentation result = default(CreatedRepresentation);
                        try
                        {
                            result = JsonConvert.DeserializeObject<CreatedRepresentation>(responseData, mSettings.Value);
                            return new ContentWebApiResponse<CreatedRepresentation>(response.StatusCode, response.ReasonPhrase, result);
                        }
                        catch (Exception exception)
                        {
                            throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Deserialize_Response_Content_Failed, typeof(CreatedRepresentation).Name), exception);
                        }
                    }
                    else if (response.StatusCode == (HttpStatusCode)422) // 422 - Unprocessable Entity
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        UnprocessableEntityRepresentation result = default(UnprocessableEntityRepresentation);
                        try
                        {
                            result = JsonConvert.DeserializeObject<UnprocessableEntityRepresentation>(responseData, mSettings.Value);
                            return new ContentWebApiResponse<UnprocessableEntityRepresentation>(response.StatusCode, response.ReasonPhrase, result);
                        }
                        catch (Exception exception)
                        {
                            throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Deserialize_Response_Content_Failed, typeof(UnprocessableEntityRepresentation).Name), exception);
                        }
                    }
                    else if (response.StatusCode != HttpStatusCode.NoContent)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        return new ContentWebApiResponse<string>(response.StatusCode, response.ReasonPhrase, responseData);
                    }
                    else
                    {
                        return new WebApiResponse(response.StatusCode, response.ReasonPhrase);
                    }
                }
                finally
                {
                    if (response != null)
                    {
                        response.Dispose();
                    }
                }
            }
        }

        public async Task<IWebApiResponse> PostMultipartAsync<TRepresentation>(Uri requestUri, TRepresentation representation, Stream stream, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                //request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/related"));
                request.RequestUri = GetAbsoluteUri(requestUri);
                MultipartContent content = new MultipartContent("related");
                request.Content = content;

                try
                {
                    var requestData = JsonConvert.SerializeObject(representation, mSettings.Value);
                    content.Add(new StringContent(requestData, Encoding.UTF8, "application/json"));
                    content.Add(new StreamContent(stream));
                }
                catch (Exception exception)
                {
                    throw new WebApiException(Resources.Strings.WebApiClient_Serialize_Request_Content_Failed, exception);
                }

                HttpResponseMessage response = await mHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

                try
                {
                    if (response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NoContent)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        CreatedRepresentation result = default(CreatedRepresentation);
                        try
                        {
                            result = JsonConvert.DeserializeObject<CreatedRepresentation>(responseData, mSettings.Value);
                            return new ContentWebApiResponse<CreatedRepresentation>(response.StatusCode, response.ReasonPhrase, result);
                        }
                        catch (Exception exception)
                        {
                            throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Deserialize_Response_Content_Failed, typeof(CreatedRepresentation).Name), exception);
                        }
                    }
                    else if (response.StatusCode == (HttpStatusCode)422) // 422 - Unprocessable Entity
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        UnprocessableEntityRepresentation result = default(UnprocessableEntityRepresentation);
                        try
                        {
                            result = JsonConvert.DeserializeObject<UnprocessableEntityRepresentation>(responseData, mSettings.Value);
                            return new ContentWebApiResponse<UnprocessableEntityRepresentation>(response.StatusCode, response.ReasonPhrase, result);
                        }
                        catch (Exception exception)
                        {
                            throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Deserialize_Response_Content_Failed, typeof(UnprocessableEntityRepresentation).Name), exception);
                        }
                    }
                    else if (response.StatusCode != HttpStatusCode.NoContent)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        return new ContentWebApiResponse<string>(response.StatusCode, response.ReasonPhrase, responseData);
                    }
                    else
                    {
                        return new WebApiResponse(response.StatusCode, response.ReasonPhrase);
                    }
                }
                finally
                {
                    if (response != null)
                    {
                        response.Dispose();
                    }
                }
            }
        }

        public async Task<IWebApiResponse> PutAsync<TRepresentation>(Uri requestUri, TRepresentation representation, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Put;
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.RequestUri = GetAbsoluteUri(requestUri);
                try
                {
                    var requestData = JsonConvert.SerializeObject(representation, mSettings.Value);
                    request.Content = new StringContent(requestData, Encoding.UTF8, "application/json");
                }
                catch (Exception exception)
                {
                    throw new WebApiException(Resources.Strings.WebApiClient_Serialize_Request_Content_Failed, exception);
                }

                HttpResponseMessage response = await mHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    if (response.StatusCode == (HttpStatusCode)422) // 422 - Unprocessable Entity
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        UnprocessableEntityRepresentation result = default(UnprocessableEntityRepresentation);
                        try
                        {
                            result = JsonConvert.DeserializeObject<UnprocessableEntityRepresentation>(responseData, mSettings.Value);
                            return new ContentWebApiResponse<UnprocessableEntityRepresentation>(response.StatusCode, response.ReasonPhrase, result);
                        }
                        catch (Exception exception)
                        {
                            throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Deserialize_Response_Content_Failed, typeof(UnprocessableEntityRepresentation).Name), exception);
                        }
                    }
                    else if (response.StatusCode != HttpStatusCode.NoContent && response.StatusCode != HttpStatusCode.OK)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        return new ContentWebApiResponse<string>(response.StatusCode, response.ReasonPhrase, responseData);
                    }
                    else
                    {
                        return new WebApiResponse(response.StatusCode, response.ReasonPhrase);
                    }
                }
                finally
                {
                    if (response != null)
                    {
                        response.Dispose();
                    }
                }
            }
        }

        public async Task<IWebApiResponse> PutMultipartAsync<TRepresentation>(Uri requestUri, TRepresentation representation, Stream stream, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Put;
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/related"));
                request.RequestUri = GetAbsoluteUri(requestUri);
                MultipartContent content = new MultipartContent();
                request.Content = content;

                try
                {
                    var requestData = JsonConvert.SerializeObject(representation, mSettings.Value);
                    content.Add(new StringContent(requestData, Encoding.UTF8, "application/json"));
                    content.Add(new StreamContent(stream));
                }
                catch (Exception exception)
                {
                    throw new WebApiException(Resources.Strings.WebApiClient_Serialize_Request_Content_Failed, exception);
                }

                HttpResponseMessage response = await mHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    if (response.StatusCode == (HttpStatusCode)422) // 422 - Unprocessable Entity
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        UnprocessableEntityRepresentation result = default(UnprocessableEntityRepresentation);
                        try
                        {
                            result = JsonConvert.DeserializeObject<UnprocessableEntityRepresentation>(responseData, mSettings.Value);
                            return new ContentWebApiResponse<UnprocessableEntityRepresentation>(response.StatusCode, response.ReasonPhrase, result);
                        }
                        catch (Exception exception)
                        {
                            throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Deserialize_Response_Content_Failed, typeof(UnprocessableEntityRepresentation).Name), exception);
                        }
                    }
                    else if (response.StatusCode != HttpStatusCode.NoContent && response.StatusCode != HttpStatusCode.OK)
                    {
                        string responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        return new ContentWebApiResponse<string>(response.StatusCode, response.ReasonPhrase, responseData);
                    }
                    else
                    {
                        return new WebApiResponse(response.StatusCode, response.ReasonPhrase);
                    }
                }
                finally
                {
                    if (response != null)
                    {
                        response.Dispose();
                    }
                }
            }
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return await mHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        }

        protected IDictionary<string, IEnumerable<string>> CollectResponseHeaders(HttpResponseMessage response)
        {
            var headers = Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
            foreach (var item in response.Content.Headers)
            {
                headers[item.Key] = item.Value;
            }
            return headers;
        }

        protected virtual void UpdateJsonSerializerSettings(JsonSerializerSettings settings)
        {
        }
    }
}