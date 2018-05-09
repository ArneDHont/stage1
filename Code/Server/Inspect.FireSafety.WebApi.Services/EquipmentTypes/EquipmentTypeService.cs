using Inspect.FireSafety.Business.EquipmentTypes;
using Inspect.FireSafety.Shared;
using Inspect.FireSafety.WebApi.FeedbackTypes;
using Inspect.Framework.Hypermedia;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace Inspect.FireSafety.WebApi.EquipmentTypes
{
    [RoutePrefix("fire-safety/equipment-types")]
    public class EquipmentTypeService : HypermediaApiController
    {
        private IEquipmentTypeBusinessComponent mBusinessComponent;

        public EquipmentTypeService()
        {
            this.IncludeHypermediaForEquipmentTypeRepresentation();
            this.IncludeHypermediaForEquipmentTypeCollectionRepresentation();
        }

        public EquipmentTypeService(IEquipmentTypeBusinessComponent businessComponent)
        {
            mBusinessComponent = businessComponent;
        }

        public IEquipmentTypeBusinessComponent BusinessComponent
        {
            get
            {
                return mBusinessComponent ?? (mBusinessComponent = new EquipmentTypeBusinessComponent());
            }
            set
            {
                mBusinessComponent = value;
            }
        }

        [HttpGet]
        [Route("", Name = nameof(EquipmentTypeCollectionGet))]
        public IHttpActionResult EquipmentTypeCollectionGet([FromUri] EquipmentTypeCollectionParameters parameters)
        {
            int totalCount = BusinessComponent.Count(new EquipmentTypeCollectionParametersSpecification(parameters));
            IEnumerable<EquipmentType> equipmentTypesFromDataAccess = BusinessComponent.Get(new EquipmentTypeCollectionParametersQuery(parameters));
            return Ok<EquipmentTypeRepresentation>(equipmentTypesFromDataAccess, totalCount, parameters?.PageNumber, parameters?.PageSize);
        }

        [HttpOptions]
        [Route("", Name = nameof(EquipmentTypeCollectionOptions))]
        public IHttpActionResult EquipmentTypeCollectionOptions()
        {
            var representation = new CollectionRepresentation<EquipmentTypeRepresentation>();
            Hypermedia.ProcessRepresentation(representation, out OptionsRepresentation result);
            return Options(result, HttpMethod.Get, HttpMethod.Options);
        }

        [HttpGet]
        [Route("{id}", Name = nameof(EquipmentTypeGetById))]
        public IHttpActionResult EquipmentTypeGetById(int id, [FromUri] EquipmentTypeParameters parameters)
        {
            var equipmentTypeFromDataAccess = BusinessComponent.SingleOrDefault(new EquipmentTypeParametersQuery(id, parameters));
            if (equipmentTypeFromDataAccess == null)
            {
                NotFound();
            }
            return Ok<EquipmentTypeRepresentation>(equipmentTypeFromDataAccess);
        }

        [HttpOptions]
        [Route("{id}", Name = nameof(EquipmentTypeOptionsById))]
        public IHttpActionResult EquipmentTypeOptionsById(int id)
        {
            EquipmentType equipmentTypeFromDataAccess = BusinessComponent.SingleOrDefault<EquipmentType>(new EquipmentTypeIdSpecification(id));
            if (equipmentTypeFromDataAccess == null)
            {
                return NotFound();
            }
            return Options<EquipmentTypeRepresentation>(equipmentTypeFromDataAccess, HttpMethod.Get, HttpMethod.Options);
        }

        [HttpGet]
        [Route("{id}/feedback-types", Name = nameof(equipmentTypeFeedbackGetById))]
        public IHttpActionResult equipmentTypeFeedbackGetById(int id)
        {
            if (BusinessComponent.SingleOrDefault<EquipmentType>(new EquipmentTypeIdSpecification(id)) == null)
            {
                return NotFound();
            }
            IEnumerable<FeedbackType> FeedbackTypeFromDataAccess = BusinessComponent.Get<FeedbackType>(new EquipmentTypeIdSpecification(id));
            return Ok<FeedbackTypeRepresentation>(FeedbackTypeFromDataAccess);
        }
    }
}