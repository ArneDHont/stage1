using Inspect.Framework.Hypermedia;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Inspect.WebApi.Host.Configuration
{
    /// <summary>
    /// Response handler that adds the default hypermedia links, when not specified in the response.
    /// </summary>
    public class HypermediaResponseHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            return HandleResponse(request, response);
        }

        private HttpResponseMessage HandleResponse(HttpRequestMessage request, HttpResponseMessage response)
        {
            if (response.TryGetContentValue(out object content) && content is Representation)
            {
                Representation representation = content as Representation;
                if (representation.Links.Self == null)
                {
                    representation.Links.Self = new Link(request.RequestUri.PathAndQuery);
                }
            }
            return response;
        }
    }
}