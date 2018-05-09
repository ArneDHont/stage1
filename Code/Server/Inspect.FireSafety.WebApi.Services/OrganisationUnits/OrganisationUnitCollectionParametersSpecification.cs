using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.WebApi.OrganisationUnits
{
    public class OrganisationUnitCollectionParametersSpecification : IEntitySpecification<OrganisationUnit>
    {
        public OrganisationUnitCollectionParametersSpecification(OrganisationUnitCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public OrganisationUnitCollectionParameters Parameters { get; private set; }

        public Expression<Func<OrganisationUnit, bool>> ToExpression()
        {
            return EntitySpecification.Default<OrganisationUnit>()
                    .ToExpression();
        }
    }
}