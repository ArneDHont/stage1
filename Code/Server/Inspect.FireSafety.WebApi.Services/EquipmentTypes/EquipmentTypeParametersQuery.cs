using Inspect.FireSafety.Business.EquipmentTypes;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System.Linq;

namespace Inspect.FireSafety.WebApi.EquipmentTypes
{
    public class EquipmentTypeParametersQuery : IEntityQuery<EquipmentType>
    {
        public EquipmentTypeParametersQuery(int equipmentTypeId, EquipmentTypeParameters parameters = null)
        {
            EquipmentTypeId = equipmentTypeId;
            Parameters = parameters;
        }

        public int EquipmentTypeId { get; private set; }

        public EquipmentTypeParameters Parameters { get; private set; }

        public IQueryable<EquipmentType> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<EquipmentType>()
                      .Where(new EquipmentTypeIdSpecification(EquipmentTypeId));

            return q.OrderBy(x => x.Name);
        }
    }
}