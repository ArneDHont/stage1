using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.EquipmentFeedbacks
{
    public class InspectionEquipmentFeedbackCollectionParametersQuery : IEntityQuery<InspectionEquipmentFeedback>
    {
        public InspectionEquipmentFeedbackCollectionParametersQuery(InspectionEquipmentFeedbackCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public InspectionEquipmentFeedbackCollectionParameters Parameters { get; private set; }

        public IQueryable<InspectionEquipmentFeedback> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<InspectionEquipmentFeedback>();
            q = q.Include(x => x.Operator);
            q = q.Include(x => x.FeedbackType);
            q = q.OrderByDescending(x => x.TimeCompleted);
            return q;
        }
    }
}
