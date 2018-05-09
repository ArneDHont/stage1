using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.EquipmentFeedbacks
{
    public class InspectionEquipmentFeedbackCollectionParametersSpecification : IEntitySpecification<InspectionEquipmentFeedback>
    {
        public InspectionEquipmentFeedbackCollectionParametersSpecification(InspectionEquipmentFeedbackCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public InspectionEquipmentFeedbackCollectionParameters Parameters { get; private set; }

        public Expression<Func<InspectionEquipmentFeedback, bool>> ToExpression()
        {
            return EntitySpecification.Default<InspectionEquipmentFeedback>().ToExpression();
        }
    }
}
