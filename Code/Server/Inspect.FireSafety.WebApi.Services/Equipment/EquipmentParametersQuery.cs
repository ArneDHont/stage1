using Inspect.FireSafety.Business.Equipment;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class EquipmentParametersQuery : IEntityQuery<Shared.Equipment>
    {
        public EquipmentParametersQuery(long equipmentId, EquipmentParameters parameters = null)
        {

            EquipmentId = equipmentId;
            Parameters = parameters;
            Barcode = "";

        }
        public EquipmentParametersQuery(string barcode, EquipmentParameters parameters = null)
        {
            EquipmentId = 0;
            Parameters = parameters;
            Barcode = barcode;
        }

        public long EquipmentId { get; private set; }
        public EquipmentParameters Parameters { get; private set; }
        public string Barcode { get; private set; }

        public IQueryable<Shared.Equipment> Execute(IEntityQueryModel db)
        {

            if (EquipmentId != 0)
            {
                var q = db.Queryable<Shared.Equipment>().Where(new EquipmentIdSpecification(EquipmentId));
                return q;
            }
            else if (Barcode != "")
            {
                var q = db.Queryable<Shared.Equipment>().Include(x => x.EquipmentIdentifications);
                q = q.Where(x => x.EquipmentIdentifications.Any(z => z.Value == Barcode));
                q = q.Include(x => x.EquipmentLocation);
                q = q.Include(x => x.EquipmentType);
                return q;
            }

            return null;


        }
    }
}
