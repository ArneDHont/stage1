
using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.FeedbackTypes
{
    internal static class HypermediaExtensions
    {
        

        public static void IncludeHypermediaForFeedbackTypeCollectionRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<CollectionRepresentation<FeedbackTypeRepresentation>>("parameters", (r) => new Link($"{controller.Url.Route(nameof(FeedbackTypeService.FeedbackTypesCollectionGet), null)}{{/id}}{{?page-number,page-size}}") { Templated = true });
        }
    }
}
