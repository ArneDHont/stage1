using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Framework.Hypermedia
{
    public interface IWebApiClient
    {
        string BaseUrl { get; }

        Task<IWebApiResponse> DeleteAsync(Uri requestUri, CancellationToken cancellationToken);

        Task<IWebApiResponse> GetAsync<TRepresentation>(Uri requestUri, CancellationToken cancellationToken);

        Task<IWebApiResponse> GetStreamAsync(Uri requestUri, CancellationToken cancellationToken);

        Task<IWebApiResponse> OptionsAsync(Uri requestUri, CancellationToken cancellationToken);

        Task<IWebApiResponse> PostAsync<TRepresentation>(Uri requestUri, TRepresentation representation, CancellationToken cancellationToken);

        Task<IWebApiResponse> PostMultipartAsync<TRepresentation>(Uri requestUri, TRepresentation representation, Stream stream, CancellationToken cancellationToken);

        Task<IWebApiResponse> PutAsync<TRepresentation>(Uri requestUri, TRepresentation representation, CancellationToken cancellationToken);

        Task<IWebApiResponse> PutMultipartAsync<TRepresentation>(Uri requestUri, TRepresentation representation, Stream stream, CancellationToken cancellationToken);

        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken);
    }

    public static class WebApiClientExtensions
    {
        public static Task DeleteEnsureAsync(this IWebApiClient instance, string link, UriKind uriKind = UriKind.Relative)
        {
            return instance.DeleteEnsureAsync(link, CancellationToken.None, uriKind);
        }

        public static async Task DeleteEnsureAsync(this IWebApiClient instance, string link, CancellationToken cancellationToken, UriKind uriKind = UriKind.Relative)
        {
            Uri requestUri = new Uri(link, uriKind);
            var result = await instance.DeleteAsync(requestUri, cancellationToken);
            result.EnsureSuccessStatusCode();
        }

        public static async Task DeleteEnsureAsync(this IWebApiClient instance, Uri requestUri, CancellationToken cancellationToken)
        {
            var result = await instance.DeleteAsync(requestUri, cancellationToken);
            result.EnsureSuccessStatusCode();
        }

        public static async Task<Uri> GetAbsoluteUriFromHypermediaAsync(this IWebApiClient instance, string link, CancellationToken cancellationToken)
        {
            Uri baseUri = new Uri(instance.BaseUrl);

            var content = await instance.GetEnsureAsync<Representation>(baseUri, cancellationToken);

            if (!content.Links.ContainsRelation(link))
            {
                throw new WebApiException($"Link with name <{link}> was not found.");
            }
            return new Uri(baseUri, content.Links.GetLink(link).AsUri());
        }

        public static async Task<Uri> GetAbsoluteUriFromHypermediaAsync(this IWebApiClient instance, string module, string link, CancellationToken cancellationToken)
        {
            Uri baseUri = await instance.GetAbsoluteUriFromHypermediaAsync(module, cancellationToken);

            var content = await instance.GetEnsureAsync<Representation>(baseUri, cancellationToken);

            if (!content.Links.ContainsRelation(link))
            {
                throw new WebApiException($"Link with name <{link}> was not found.");
            }
            return new Uri(baseUri, content.Links.GetLink(link).AsUri());
        }

        public static Task<TRepresentation> GetEnsureAsync<TRepresentation>(this IWebApiClient instance, string link, UriKind uriKind = UriKind.Relative)
        {
            return instance.GetEnsureAsync<TRepresentation>(link, CancellationToken.None, uriKind);
        }

        public static async Task<TRepresentation> GetEnsureAsync<TRepresentation>(this IWebApiClient instance, string link, CancellationToken cancellationToken, UriKind uriKind = UriKind.Relative)
        {
            Uri requestUri = new Uri(link, uriKind);
            var result = await instance.GetAsync<TRepresentation>(requestUri, cancellationToken);
            return result.EnsureContent<TRepresentation>();
        }

        public static async Task<TRepresentation> GetEnsureAsync<TRepresentation>(this IWebApiClient instance, Uri requestUri, CancellationToken cancellationToken)
        {
            var result = await instance.GetAsync<TRepresentation>(requestUri, cancellationToken);
            return result.EnsureContent<TRepresentation>();
        }

        public static Task<OptionsRepresentation> OptionsEnsureAsync(this IWebApiClient instance, string link, UriKind uriKind = UriKind.Relative)
        {
            return instance.OptionsEnsureAsync(link, CancellationToken.None, uriKind);
        }

        public async static Task<OptionsRepresentation> OptionsEnsureAsync(this IWebApiClient instance, string link, CancellationToken cancellationToken, UriKind uriKind = UriKind.Relative)
        {
            Uri requestUri = new Uri(link, uriKind);
            var result = await instance.OptionsAsync(requestUri, cancellationToken);
            return result.EnsureContent<OptionsRepresentation>();
        }

        public static async Task<OptionsRepresentation> OptionsEnsureAsync(this IWebApiClient instance, Uri requestUri, CancellationToken cancellationToken)
        {
            var result = await instance.OptionsAsync(requestUri, cancellationToken);
            return result.EnsureContent<OptionsRepresentation>();
        }

        public static Task<CreatedRepresentation> PostEnsureAsync<TRepresentation>(this IWebApiClient instance, string link, TRepresentation representation, UriKind uriKind = UriKind.Relative)
        {
            return instance.PostEnsureAsync(link, representation, CancellationToken.None, uriKind);
        }

        public async static Task<CreatedRepresentation> PostEnsureAsync<TRepresentation>(this IWebApiClient instance, string link, TRepresentation representation, CancellationToken cancellationToken, UriKind uriKind = UriKind.Relative)
        {
            Uri requestUri = new Uri(link, uriKind);
            var result = await instance.PostAsync(requestUri, representation, cancellationToken);
            return result.EnsureContent<CreatedRepresentation>();
        }

        public static async Task<CreatedRepresentation> PostEnsureAsync<TRepresentation>(this IWebApiClient instance, Uri requestUri, TRepresentation representation, CancellationToken cancellationToken)
        {
            var result = await instance.PostAsync(requestUri, representation, cancellationToken);
            return result.EnsureContent<CreatedRepresentation>();
        }

        public static Task PutEnsureAsync<TRepresentation>(this IWebApiClient instance, string link, TRepresentation representation, UriKind uriKind = UriKind.Relative)
        {
            return instance.PutEnsureAsync(link, representation, CancellationToken.None, uriKind);
        }

        public async static Task PutEnsureAsync<TRepresentation>(this IWebApiClient instance, string link, TRepresentation representation, CancellationToken cancellationToken, UriKind uriKind = UriKind.Relative)
        {
            Uri requestUri = new Uri(link, uriKind);
            var result = await instance.PutAsync(requestUri, representation, cancellationToken);
            result.EnsureSuccessStatusCode();
        }

        public static async Task PutEnsureAsync<TRepresentation>(this IWebApiClient instance, Uri requestUri, TRepresentation representation, CancellationToken cancellationToken)
        {
            var result = await instance.PutAsync(requestUri, representation, cancellationToken);
            result.EnsureSuccessStatusCode();
        }
    }
}