using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System.Linq;

namespace Inspect.FireSafety.WebApi.OrganisationUnits
{
    public class OrganisationUnitCollectionParametersQuery : IEntityQuery<OrganisationUnit>
    {
        public OrganisationUnitCollectionParametersQuery(OrganisationUnitCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public OrganisationUnitCollectionParameters Parameters { get; private set; }

        public IQueryable<OrganisationUnit> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<OrganisationUnit>();

            q = q.OrderBy(x => x.Code);

            if (Parameters != null)
            {
                q = q.Where(new OrganisationUnitCollectionParametersSpecification(Parameters));

                if (Parameters.PageSize != null)
                {
                    q = q.Paging(Parameters.PageNumber ?? 1, Parameters.PageSize.Value);
                }

                if (Parameters.EmbedLocations)
                {
                    q = q.Include(x => x.Locations);
                }
            }

            return q;
        }
    }
}