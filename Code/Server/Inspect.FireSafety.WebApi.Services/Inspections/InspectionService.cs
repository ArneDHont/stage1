using AutoMapper;
using Inspect.FireSafety.Business.Equipment;
using Inspect.FireSafety.WebApi.Equipment;
using Inspect.Framework.Hypermedia;
using Inspect.WebApi;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Inspect.FireSafety.WebApi.Inspections
{
    [RoutePrefix("fire-safety/inspections")]
    public class InspectionService : HypermediaApiController
    {
        private IEquipmentBusinessComponent mBusinessComponent;

        public InspectionService()
        {
            this.IncludeHypermediaForEquipmentCollectionRepresentation();
        }

        public InspectionService(IEquipmentBusinessComponent businessComponent) : this()
        {
            mBusinessComponent = businessComponent;
        }

        public IEquipmentBusinessComponent BusinessComponent
        {
            get
            {
                return mBusinessComponent ?? (mBusinessComponent = new EquipmentBusinessComponent());
            }
            set
            {
                mBusinessComponent = value;
            }
        }

        [HttpGet]
        [Route("", Name = nameof(InspectionCollectionGet))]
        public IHttpActionResult InspectionCollectionGet([FromUri]InspectionCollectionParameters parameters)
        {
            var locationId = parameters?.LocationId ?? new int { };
            var equipmentParameters = new EquipmentCollectionParameters() { LocationId = locationId, SelectedDate = parameters.SelectedDate, EmbedEquipmentLocation = true, EmbedEquipmentType = true };
            int totalCount = BusinessComponent.Count(new EquipmentCollectionParametersSpecification(equipmentParameters));
            var equipmentFromDataAccess = BusinessComponent.Get(new EquipmentCollectionParametersQuery(equipmentParameters));

            var inspections = CreateInspectionsFromEquipment(equipmentFromDataAccess);
            return Ok(inspections);
        }

        private CollectionRepresentation<InspectionRepresentation> CreateInspectionsFromEquipment(IEnumerable<Shared.Equipment> equipment)
        {
            //TODO Inspection creation is business logic, currenly in service to mock the behavior.
            var representations = Mapper.MapWithHypermedia<IEnumerable<EquipmentRepresentation>>(equipment, Hypermedia);
            List<InspectionRepresentation> inspections = new List<InspectionRepresentation>();
            inspections.AddRange(representations.Select(x => new InspectionRepresentation() { Equipment = x, Title = "Visuele Controle", Description = "Is visueel alles in orde?" }));
            return CreateCollectionRepresentation<InspectionRepresentation>(inspections);
        }

        [HttpPost]
        [Route("{id}/attachments", Name = nameof(AttachmentCollectionPost))]
        public IHttpActionResult AttachmentCollectionPost(int id, [FromBody]Upload<OrganisationUnitRepresentation> upload)
        {
            return Ok();
        }
    }
}