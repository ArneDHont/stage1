using Inspect.Framework.Hypermedia;
using System.Web.Http;

namespace Inspect.FireSafety.WebApi
{
    [RoutePrefix("fire-safety")]
    public class FireSafetyService : ApiController
    {
        [HttpGet]
        [Route("", Name = nameof(FireSafetyServiceGet))]
        public IHttpActionResult FireSafetyServiceGet()
        {
            return FireSafetyServiceOptions();
        }

        [HttpOptions]
        [Route("", Name = nameof(FireSafetyServiceOptions))]
        public IHttpActionResult FireSafetyServiceOptions()
        {
            Representation metadata = new Representation();
            metadata.Link(Hypermedia.OrganisationUnits, Url.Route(nameof(OrganisationUnits.OrganisationUnitService.OrganisationUnitCollectionGet), null));
            metadata.Link(Hypermedia.Equipment, Url.Route(nameof(Equipment.EquipmentService.EquipmentCollectionGet), null));
            metadata.Link(Hypermedia.EquipmentTypes, Url.Route(nameof(EquipmentTypes.EquipmentTypeService.EquipmentTypeCollectionGet), null));
            metadata.Link(Hypermedia.Inspections, Url.Route(nameof(Inspections.InspectionService.InspectionCollectionGet), null));
            return Ok(metadata);
        }
    }
}