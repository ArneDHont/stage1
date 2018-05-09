using Inspect.Framework.Data;
using Inspect.FireSafety.Business.Equipment;
using System.Linq;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class EquipmentCollectionParametersQuery : IEntityQuery<Shared.Equipment>
    {
        public EquipmentCollectionParametersQuery(EquipmentCollectionParameters parameters = null)
        {
            Parameters = parameters;
            
        }

        public EquipmentCollectionParameters Parameters { get; private set; }
       

        public IQueryable<Shared.Equipment> Execute(IEntityQueryModel db)
        {

            var q = db.Queryable<Shared.Equipment>();
            q = q.OrderBy(x => x.EquipmentLocation.OrderNumber);

            if (Parameters != null)
            {
                q = q.Where(new EquipmentCollectionParametersSpecification(Parameters));

                if (Parameters.EmbedEquipmentType)
                {
                    q = q.Include(x => x.EquipmentType);
                }

                if (Parameters.EmbedEquipmentLocation)
                {
                    q = q.Include(x => x.EquipmentLocation);
                }

                if (Parameters.EmbedEquipmentTypeConfiguration)
                {
                    q = q.Include(x => x.EquipmentTypeConfiguration.EquipmentType);
                }

                if (Parameters.PageSize != null)
                {
                    q = q.Paging(Parameters.PageNumber ?? 1, Parameters.PageSize.Value);
                }
            }
            q = q.Include(x => x.EquipmentIdentifications);            
            return q;
        }
    }
}