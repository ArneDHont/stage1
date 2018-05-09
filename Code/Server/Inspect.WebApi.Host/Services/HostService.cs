using Inspect.Framework.Hypermedia;
using System.Web.Http;

namespace Inspect.WebApi.Host.Services
{
    public class HostService : ApiController
    {
        [HttpGet]
        [Route("", Name = nameof(HostHypermediaGet))]
        public IHttpActionResult HostHypermediaGet()
        {
            // TODO links based on security.
            Representation metadata = new Representation();
            metadata.Link(nameof(FireSafety), Url.Route(nameof(FireSafety.WebApi.FireSafetyService.FireSafetyServiceGet), null));
            return Ok(metadata);
        }
    }
}