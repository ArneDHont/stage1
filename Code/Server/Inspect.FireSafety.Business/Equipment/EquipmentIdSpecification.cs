using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.Business.Equipment
{
    public class EquipmentIdSpecification : IEntitySpecification<Shared.Equipment>, IEntitySpecification<EquipmentLocation>, IEntitySpecification<InspectionEquipmentFeedback>
    {
        public EquipmentIdSpecification(long id)
        {
            EquipmentId = id;
        }

        public long EquipmentId { get; private set; }

        public Expression<Func<Shared.Equipment, bool>> ToExpression()
        {
            return x => x.EquipmentId == EquipmentId;
        }

        Expression<Func<EquipmentLocation, bool>> IEntitySpecification<EquipmentLocation>.ToExpression()
        {
            return x => x.EquipmentId == EquipmentId;
        }

        Expression<Func<InspectionEquipmentFeedback, bool>> IEntitySpecification<InspectionEquipmentFeedback>.ToExpression()
        {
            return x => x.EquipmentId == EquipmentId;
        }
    }
}
