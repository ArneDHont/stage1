using Inspect.Framework.Hypermedia;

namespace Inspect.FireSafety.WebApi.OrganisationUnits
{
    internal static class HypermediaExtensions
    {
        public static void IncludeHypermediaForOrganisationUnitRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<OrganisationUnitRepresentation>(x => controller.Url.Route(nameof(OrganisationUnitService.OrganisationUnitGetById), new { id = x.OrganisationUnitId }));
            controller.Hypermedia.ForRepresentation<OrganisationUnitRepresentation>(HypermediaLinks.Locations, x => controller.Url.Route(nameof(OrganisationUnitService.OrganisationUnitLocationsGetById), new { id = x.OrganisationUnitId }));
        }

        public static void IncludeHypermediaForOrganisationUnitCollectionRepresentation(this IHypermediaController controller)
        {
            controller.Hypermedia.ForRepresentation<CollectionRepresentation<OrganisationUnitRepresentation>>("parameters", (r) => new Link($"{controller.Url.Route(nameof(OrganisationUnitService.OrganisationUnitCollectionGet), null)}{{/id}}{{?embed-locations,page-number,page-size}}") { Templated = true });
        }
    }
}