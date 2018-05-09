using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.Business.FeedbackTypes
{
    public class FeedbackTypeSpecification : IEntitySpecification<FeedbackType>
    {

        public FeedbackTypeSpecification(int id)
        {
            FeedbackTypeId = id;
        }

        public int FeedbackTypeId { get; private set; }

        public Expression<Func<FeedbackType, bool>> ToExpression()
        {
            return x => x.FeedbackTypeId == FeedbackTypeId;
        }
    }
}
