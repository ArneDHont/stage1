using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System.Linq;

namespace Inspect.FireSafety.WebApi.EquipmentTypes
{
    public class EquipmentTypeCollectionParametersQuery : IEntityQuery<EquipmentType>
    {
        public EquipmentTypeCollectionParametersQuery(EquipmentTypeCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public EquipmentTypeCollectionParameters Parameters { get; private set; }

        public IQueryable<EquipmentType> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<EquipmentType>();

            q = q.OrderBy(x => x.Name);

            if (Parameters != null)
            {
                q = q.Where(new EquipmentTypeCollectionParametersSpecification(Parameters));

                if (Parameters.PageSize != null)
                {
                    q = q.Paging(Parameters.PageNumber ?? 1, Parameters.PageSize.Value);
                }
            }

            return q;
        }
    }
}