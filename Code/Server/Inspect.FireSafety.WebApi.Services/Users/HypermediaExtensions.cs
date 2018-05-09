using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Inspect.FireSafety.WebApi.Users
{
    internal static class HypermediaExtensions
    {
        public static void IncludeHypermediaForUserCollectionRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<CollectionRepresentation<UserRepresentation>>("parameters", (r) => new Link($"{controller.Url.Route(nameof(UserService.UserCollectionGet), null)}{{?page-number,page-size}}") { Templated = true });
        }
        public static void IncludeHypermediaForUserRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<UserRepresentation>("parameters", (r) => new Link($"{controller.Url.Route(nameof(UserService.UserGetByEmployeeNumber), null)}") { Templated = true });
        }

       
    }
}
