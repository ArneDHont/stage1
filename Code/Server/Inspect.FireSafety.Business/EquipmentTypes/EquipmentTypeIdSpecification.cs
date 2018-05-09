using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace Inspect.FireSafety.Business.EquipmentTypes
{
    public class EquipmentTypeIdArraySpecification : IEntitySpecification<EquipmentType>, IEntitySpecification<Shared.Equipment>, IEntitySpecification<EquipmentTypeConfiguration>
    {
        public EquipmentTypeIdArraySpecification(params int[] equipmentTypeId)
        {
            EquipmentTypeId = equipmentTypeId ?? new int[] { };
        }

        public int[] EquipmentTypeId { get; private set; }

        public Expression<Func<EquipmentType, bool>> ToExpression()
        {
            var specification = EntitySpecification.Default<EquipmentType>(EquipmentTypeId.Length == 0);
            foreach (var equipmentTypeId in EquipmentTypeId)
            {
                specification = specification.Or(new EquipmentTypeIdSpecification(equipmentTypeId));
            }
            return specification.ToExpression();
        }

        Expression<Func<Shared.Equipment, bool>> IEntitySpecification<Shared.Equipment>.ToExpression()
        {
            var specification = EntitySpecification.Default<Shared.Equipment>(EquipmentTypeId.Length == 0);
            foreach (var equipmentTypeId in EquipmentTypeId)
            {
                specification = specification.Or(new EquipmentTypeIdSpecification(equipmentTypeId));
            }
            return specification.ToExpression();
        }

        Expression<Func<EquipmentTypeConfiguration, bool>> IEntitySpecification<EquipmentTypeConfiguration>.ToExpression()
        {
            var specification = EntitySpecification.Default<Shared.EquipmentTypeConfiguration>(EquipmentTypeId.Length == 0);
            foreach (var equipmentTypeId in EquipmentTypeId)
            {
                specification = specification.Or(new EquipmentTypeIdSpecification(equipmentTypeId));
            }
            return specification.ToExpression();
        }
    }

    public class EquipmentTypeIdSpecification : IEntitySpecification<FeedbackType>, IEntitySpecification<EquipmentType>, IEntitySpecification<Shared.Equipment>, IEntitySpecification<EquipmentTypeConfiguration>
    {
        public EquipmentTypeIdSpecification(int equipmentTypeId)
        {
            EquipmentTypeId = equipmentTypeId;
        }

        public int EquipmentTypeId { get; private set; }

        public Expression<Func<EquipmentType, bool>> ToExpression()
        {
            return x => x.EquipmentTypeId == EquipmentTypeId;
        }

        Expression<Func<Shared.Equipment, bool>> IEntitySpecification<Shared.Equipment>.ToExpression()
        {
            return x => x.EquipmentTypeId == EquipmentTypeId;
        }

        Expression<Func<EquipmentTypeConfiguration, bool>> IEntitySpecification<EquipmentTypeConfiguration>.ToExpression()
        {
            return x => x.EquipmentTypeId == EquipmentTypeId;
        }

        Expression<Func<FeedbackType, bool>> IEntitySpecification<FeedbackType>.ToExpression()
        {
            return x => x.EquipmentTypes.Any(e => e.EquipmentTypeId == EquipmentTypeId);
        }
    }
}