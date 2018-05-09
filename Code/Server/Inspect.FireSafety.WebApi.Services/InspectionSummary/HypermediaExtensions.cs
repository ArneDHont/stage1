using Inspect.FireSafety.WebApi.Contracts.InspectionSummary;
using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.InspectionSummary
{
    internal static class HypermediaExtensions
    {
        public static void IncludeHypermediaForInspectionSummaryRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<InspectionSummaryRepresentation>(x => controller.Url.Route(nameof(InspectionSummaryService.InspectionSummaryGetById), new { id = x.InspectionSummaryId }));
        }
    }
}
