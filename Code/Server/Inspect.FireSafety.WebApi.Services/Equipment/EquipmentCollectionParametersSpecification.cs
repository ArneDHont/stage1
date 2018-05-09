using Inspect.FireSafety.Business.Equipment;
using Inspect.FireSafety.Business.EquipmentTypes;
using Inspect.FireSafety.Business.Locations;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class EquipmentCollectionParametersSpecification : IEntitySpecification<Shared.Equipment>
    {
        public EquipmentCollectionParametersSpecification(EquipmentCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public EquipmentCollectionParameters Parameters { get; private set; }

        public Expression<Func<Shared.Equipment, bool>> ToExpression()
        {
            return EntitySpecification.Default<Shared.Equipment>()
                .And(new EquipmentTypeIdArraySpecification(Parameters?.EquipmentTypeId))
                .And(new LocationIdArraySpecification(Parameters.LocationId))
                .And(new VisualInspectionDateSpecification(Parameters?.SelectedDate))
                    .ToExpression();
        }
    }
}