using Inspect.FireSafety.Business.EquipmentTypes;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.WebApi.EquipmentTypes
{
    public class EquipmentTypeCollectionParametersSpecification : IEntitySpecification<EquipmentType>
    {
        public EquipmentTypeCollectionParametersSpecification(EquipmentTypeCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public EquipmentTypeCollectionParameters Parameters { get; private set; }

        public Expression<Func<EquipmentType, bool>> ToExpression()
        {
            return EntitySpecification.Default<EquipmentType>()
                .And(new CodeArraySpecification(Parameters?.Code))
                    .ToExpression();
        }
    }
}