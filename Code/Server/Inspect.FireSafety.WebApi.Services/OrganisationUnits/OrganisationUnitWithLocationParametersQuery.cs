using Inspect.FireSafety.Shared;
using Inspect.FireSafety.WebApi.Locations;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.OrganisationUnits
{
    public class OrganisationUnitWithLocationParametersQuery : IEntityQuery<Location>
    {
        public OrganisationUnitWithLocationParametersQuery(int id,  LocationCollectionParameters parameters = null)
        {
            OrganisationUnitId = id;
            Parameters = parameters;
        }

        public int OrganisationUnitId { get; private set; }
        public LocationCollectionParameters Parameters { get; private set; }

        public IQueryable<Location> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<Location>().Where(x => x.OrganisationUnitId == OrganisationUnitId);                      
            q = q.OrderBy(x => x.Name);
            return q;
        }
    }
}
