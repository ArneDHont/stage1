using Inspect.FireSafety.Business.Equipment;
using Inspect.FireSafety.Shared;
using Inspect.FireSafety.WebApi.EquipmentFeedbacks;
using Inspect.WebApi;
using System.Collections.Generic;
using System.Web.Http;

namespace Inspect.FireSafety.WebApi.Equipment
{
    [RoutePrefix("fire-safety/equipment")]
    public class EquipmentService : HypermediaApiController
    {
        private IEquipmentBusinessComponent mBusinessComponent;

        public EquipmentService()
        {
            
            this.IncludeHypermediaForEquipmentCollectionRepresentation();
        }

        public EquipmentService(IEquipmentBusinessComponent businessComponent) : this()
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
        [Route("", Name = nameof(EquipmentCollectionGet))]
        public IHttpActionResult EquipmentCollectionGet([FromUri]EquipmentCollectionParameters parameters)
        {
            parameters = parameters ?? new EquipmentCollectionParameters();
            int totalCount = BusinessComponent.Count(new EquipmentCollectionParametersSpecification(parameters));
            IEnumerable<Shared.Equipment> organisationUnitsFromDataAccess = BusinessComponent.Get(new EquipmentCollectionParametersQuery(parameters));
            return Ok<EquipmentRepresentation>(organisationUnitsFromDataAccess, totalCount, parameters?.PageNumber, parameters?.PageSize);
        }

        [HttpGet]
        [Route("{id}", Name = nameof(EquipmentGetById))]
        public IHttpActionResult EquipmentGetById(long id, [FromUri]EquipmentParameters parameters)
        {          
            var equipmentFromDataAccess = BusinessComponent.SingleOrDefault(new EquipmentParametersQuery(id, parameters));
            if (equipmentFromDataAccess == null)
            {
                return NotFound();
            }
            return Ok<EquipmentRepresentation>(equipmentFromDataAccess);
        }

        [HttpGet]
        [Route("barcode/{barcode}", Name = nameof(EquipmentGetByBarcode))]
        public IHttpActionResult EquipmentGetByBarcode(string barcode, [FromUri]EquipmentParameters parameters)
        {
            var equipmentFromDataAccess = BusinessComponent.SingleOrDefault(new EquipmentParametersQuery(barcode,parameters));
            if (equipmentFromDataAccess == null)
            {
                return NotFound();
            }
            return Ok<EquipmentRepresentation>(equipmentFromDataAccess);
        }

        [HttpGet]
        [Route("{id}/equipmentfeedback", Name = nameof(EquipmentGetEquipmentFeedback))]
        public IHttpActionResult EquipmentGetEquipmentFeedback(long id, [FromUri]InspectionEquipmentFeedbackCollectionParameters parameters)
        {
            parameters = parameters ?? new InspectionEquipmentFeedbackCollectionParameters();            
            IEnumerable < Shared.InspectionEquipmentFeedback> inspectionEquipmentFeedbackFromDataAccess = BusinessComponent.Get(new EquipmentWithFeedbackParametersQuery(id, parameters));
            return Ok<InspectionEquipmentFeedbackRepresentation>(inspectionEquipmentFeedbackFromDataAccess);
        }
        
    }
}