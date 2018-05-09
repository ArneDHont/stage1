using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.Business.Equipment
{
    public class VisualInspectionDateSpecification : IEntitySpecification<Shared.Equipment>
    {
        public VisualInspectionDateSpecification(DateTime? dateTime)
        {
            DateTime = dateTime;
        }

        public DateTime? DateTime { get; set; }

        public Expression<Func<Shared.Equipment, bool>> ToExpression()
        {
            if (DateTime.HasValue)
            {
                return x => EntityFunctions.TruncateTime(x.DateVisualInspection.Value) <= EntityFunctions.TruncateTime(DateTime);
            }
            else
            {
                return x => x.DateVisualInspection == null;
            }
        }
    }
}