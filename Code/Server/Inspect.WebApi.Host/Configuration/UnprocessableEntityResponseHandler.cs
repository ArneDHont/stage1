using Inspect.Framework.Hypermedia;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Inspect.WebApi.Host.Configuration
{
    /// <summary>
    /// This class handles <see cref="HttpError"/> responses and converts them into UnprocessableEntity responses when model validation failed.
    /// </summary>
    public class UnprocessableEntityResponseHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            return HandleResponse(request, response);
        }

        private HttpResponseMessage HandleResponse(HttpRequestMessage request, HttpResponseMessage response)
        {
            object content;
            if (response.TryGetContentValue(out content) && !response.IsSuccessStatusCode)
            {
                HttpError error = content as HttpError;
                if (error != null && error.ModelState != null)
                {
                    List<ValidationErrorRepresentation> validationErrorList = new List<ValidationErrorRepresentation>();
                    foreach (var kvp in error.ModelState)
                    {
                        validationErrorList.Add(new ValidationErrorRepresentation() { Path = kvp.Key, Messages = (string[])kvp.Value });
                    }

                    // Create the new response including the original headers. (422 - Unprocessable Entity)
                    var newResponse = request.CreateResponse((HttpStatusCode)422, new UnprocessableEntityRepresentation() { Errors = validationErrorList });
                    foreach (var header in response.Headers)
                    {
                        newResponse.Headers.Add(header.Key, header.Value);
                    }
                    return newResponse;
                }
            }
            return response;
        }
    }
}