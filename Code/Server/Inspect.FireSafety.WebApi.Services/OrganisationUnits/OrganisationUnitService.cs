using Inspect.FireSafety.Business.OrganisationUnits;
using Inspect.FireSafety.Shared;
using Inspect.FireSafety.WebApi.Locations;
using Inspect.Framework.Hypermedia;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace Inspect.FireSafety.WebApi.OrganisationUnits
{
    [RoutePrefix("fire-safety/organisation-units")]
    public class OrganisationUnitService : HypermediaApiController
    {
        private IOrganisationUnitBusinessComponent mBusinessComponent;

        public OrganisationUnitService()
        {
            this.IncludeHypermediaForOrganisationUnitRepresentation();
            this.IncludeHypermediaForOrganisationUnitCollectionRepresentation();
        }

        public OrganisationUnitService(IOrganisationUnitBusinessComponent businessComponent) : this()
        {
            mBusinessComponent = businessComponent;
        }

        public IOrganisationUnitBusinessComponent BusinessComponent
        {
            get
            {
                return mBusinessComponent ?? (mBusinessComponent = new OrganisationUnitBusinessComponent());
            }
            set
            {
                mBusinessComponent = value;
            }
        }

        [HttpGet]
        [Route("", Name = nameof(OrganisationUnitCollectionGet))]
        public IHttpActionResult OrganisationUnitCollectionGet([FromUri]OrganisationUnitCollectionParameters parameters)
        {
            int totalCount = BusinessComponent.Count(new OrganisationUnitCollectionParametersSpecification(parameters));
            IEnumerable<OrganisationUnit> organisationUnitsFromDataAccess = BusinessComponent.Get(new OrganisationUnitCollectionParametersQuery(parameters));
            return Ok<OrganisationUnitRepresentation>(organisationUnitsFromDataAccess, totalCount, parameters?.PageNumber, parameters?.PageSize);
        }

        [HttpOptions]
        [Route("", Name = nameof(OrganisationUnitCollectionOptions))]
        public IHttpActionResult OrganisationUnitCollectionOptions()
        {
            var representation = new CollectionRepresentation<OrganisationUnitRepresentation>();
            Hypermedia.ProcessRepresentation(representation, out OptionsRepresentation result);
            return Options(result, HttpMethod.Get, HttpMethod.Options);
        }

        [HttpGet]
        [Route("{id}", Name = nameof(OrganisationUnitGetById))]
        public IHttpActionResult OrganisationUnitGetById(int id, [FromUri]OrganisationUnitParameters parameters)
        {
            var organisationUnitFromDataAccess = BusinessComponent.SingleOrDefault(new OrganisationUnitParametersQuery(id, parameters));
            if (organisationUnitFromDataAccess == null)
            {
                return NotFound();
            }
            return Ok<OrganisationUnitRepresentation>(organisationUnitFromDataAccess);
        }

        [HttpGet]
        [Route("{id}/locations", Name = nameof(OrganisationUnitLocationsGetById))]
        public IHttpActionResult OrganisationUnitLocationsGetById(int id, [FromUri]LocationCollectionParameters parameters)
        {
            parameters = parameters ?? new LocationCollectionParameters();
            IEnumerable<Location> LocationsFromDataAccess = BusinessComponent.Get(new OrganisationUnitWithLocationParametersQuery(id, parameters));
            return Ok<LocationRepresentation>(LocationsFromDataAccess);
        }

        [HttpOptions]
        [Route("{id}", Name = nameof(OrganisationUnitOptionsById))]
        public IHttpActionResult OrganisationUnitOptionsById(int id)
        {
            OrganisationUnit organisationUnitFromDataAccess = BusinessComponent.SingleOrDefault<OrganisationUnit>(new OrganisationUnitIdSpecification(id));
            if (organisationUnitFromDataAccess == null)
            {
                return NotFound();
            }
            return Options<OrganisationUnitRepresentation>(organisationUnitFromDataAccess, HttpMethod.Get, HttpMethod.Options);
        }
    }
}