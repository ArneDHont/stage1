using Inspect.FireSafety.Business.OrganisationUnits;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System.Linq;

namespace Inspect.FireSafety.WebApi.OrganisationUnits
{
    public class OrganisationUnitParametersQuery : IEntityQuery<OrganisationUnit>
    {
        public OrganisationUnitParametersQuery(int organisationUnitId, OrganisationUnitParameters parameters = null)
        {
            OrganisationUnitId = organisationUnitId;
            Parameters = parameters;
            
        }

        public int OrganisationUnitId { get; private set; }

        public OrganisationUnitParameters Parameters { get; private set; }

        public IQueryable<OrganisationUnit> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<OrganisationUnit>()
                      .Where(new OrganisationUnitIdSpecification(OrganisationUnitId));

            if (Parameters != null)
            {
                if (Parameters.EmbedLocations)
                {
                    q = q.Include(x => x.Locations);
                }
            }

            return q.OrderBy(x => x.OrganisationUnitId);
        }
    }
}