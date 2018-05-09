using Inspect.FireSafety.WebApi.Equipment;
using Inspect.FireSafety.WebApi.OrganisationUnits;
using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.Equipment
{
     internal static class HypermediaExtensions
    {
        

        public static void IncludeHypermediaForEquipmentCollectionRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<CollectionRepresentation<EquipmentRepresentation>>("parameters", (r) => new Link($"{controller.Url.Route(nameof(EquipmentService.EquipmentCollectionGet), null)}{{/id}}{{?Weight,embed-locations,SelectedDate,page-number,page-size}}") { Templated = true });
        }
    }
}
