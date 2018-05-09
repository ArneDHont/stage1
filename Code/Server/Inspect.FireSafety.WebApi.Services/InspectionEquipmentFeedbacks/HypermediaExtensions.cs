using Inspect.FireSafety.WebApi.InspectionEquipmentFeedbacks;
using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.EquipmentFeedbacks
{
    internal static class HypermediaExtensions
    {
        public static void IncludeHypermediaForEquipmentFeedbackCollectionRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<CollectionRepresentation<InspectionEquipmentFeedbackRepresentation>>("parameters", (r) => new Link($"{controller.Url.Route(nameof(InspectionEquipmentFeedbackService.EquipmentFeedbackCollectionGet), null)}{{?page-number,page-size}}") { Templated = true });
        }

        public static void IncludeHypermediaForEquipmentFeedbackRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<InspectionEquipmentFeedbackRepresentation>(x => controller.Url.Route(nameof(InspectionEquipmentFeedbackService.EquipmentFeedbacksGetById), new { id = x.InspectionEquipmentFeedbackId }));
        }
        
    }
}
