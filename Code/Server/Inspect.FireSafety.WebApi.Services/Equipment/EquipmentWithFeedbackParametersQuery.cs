using Inspect.FireSafety.Shared;
using Inspect.FireSafety.WebApi.EquipmentFeedbacks;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class EquipmentWithFeedbackParametersQuery : IEntityQuery<InspectionEquipmentFeedback>
    {
        public EquipmentWithFeedbackParametersQuery(long id,InspectionEquipmentFeedbackCollectionParameters  parameters = null)
        {
            EquipmentId = id;
            Parameters = parameters;
        }

        public long EquipmentId { get; private set; }
        public InspectionEquipmentFeedbackCollectionParameters Parameters { get; private set; }

        public IQueryable<InspectionEquipmentFeedback> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<InspectionEquipmentFeedback>().Where(x=> x.EquipmentId == EquipmentId);
            q = q.Include(x => x.Operator);

            q = q.Include(x => x.FeedbackType);
            q = q.OrderByDescending(x => x.TimeCompleted);
            return q;
        }
    }
}
