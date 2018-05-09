using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.Business.OrganisationUnits
{
    public class OrganisationUnitIdSpecification : IEntitySpecification<OrganisationUnit>, IEntitySpecification<Location>
    {
        public OrganisationUnitIdSpecification(int id)
        {
            OrganisationalUnitId = id;
        }

        public int OrganisationalUnitId { get; private set; }

        public Expression<Func<OrganisationUnit, bool>> ToExpression()
        {
            return x => x.OrganisationUnitId == OrganisationalUnitId;
        }

        Expression<Func<Location, bool>> IEntitySpecification<Location>.ToExpression()
        {
            return x => x.OrganisationUnitId == OrganisationalUnitId;
        }
    }
}