using System.Web.Http.Routing;

namespace Inspect.Framework.Hypermedia
{
    public interface IHypermediaController
    {
        IHypermediaHandler Hypermedia { get; }

        UrlHelper Url { get; }
    }
}