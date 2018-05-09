using Inspect.Framework.Hypermedia;

namespace Inspect.FireSafety.WebApi.EquipmentTypes
{
    internal static class HypermediaExtensions
    {
        public static void IncludeHypermediaForEquipmentTypeRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<EquipmentTypeRepresentation>(x => controller.Url.Route(nameof(EquipmentTypeService.EquipmentTypeGetById), new { id = x.EquipmentTypeId }));
        }

        public static void IncludeHypermediaForEquipmentTypeCollectionRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<CollectionRepresentation<EquipmentTypeRepresentation>>("parameters", (r) => new Link($"{controller.Url.Route(nameof(EquipmentTypeService.EquipmentTypeCollectionGet), null)}{{/id}}{{?code*,page-number,page-size}}") { Templated = true });
        }
    }
}