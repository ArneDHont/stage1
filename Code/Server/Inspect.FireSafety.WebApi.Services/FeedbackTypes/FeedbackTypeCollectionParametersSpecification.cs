using Inspect.FireSafety.Business.EquipmentTypes;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.WebApi.FeedbackTypes
{
    public class FeedbackTypeCollectionParametersSpecification : IEntitySpecification<FeedbackType>
    {
        public FeedbackTypeCollectionParametersSpecification(FeedbackTypeCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public FeedbackTypeCollectionParameters Parameters { get; private set; }

        public Expression<Func<FeedbackType, bool>> ToExpression()
        {
            return EntitySpecification.Default<FeedbackType>().ToExpression();
        }
    }
}
