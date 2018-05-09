using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.EquipmentFeedbacks
{
    public class InspectionEquipmentFeedbackSpecification : IEntitySpecification<InspectionEquipmentFeedback>
    {
        public InspectionEquipmentFeedbackSpecification(int id)
        {
            EquipmentFeedbackId = id;
        }

        public int EquipmentFeedbackId { get; private set; }

        public Expression<Func<InspectionEquipmentFeedback, bool>> ToExpression()
        {
            return x => x.InspectionEquipmentFeedbackId == EquipmentFeedbackId;
        }
    }
}
