using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspect.FireSafety.Business.FeedbackTypes;

namespace Inspect.FireSafety.WebApi.FeedbackTypes
{
    public class FeedbackTypeParametersQuery : IEntityQuery<FeedbackType>
    {
        public FeedbackTypeParametersQuery(int feedbackTypeId, FeedbackTypeParameters parameters = null)
        {
            FeedbackTypeId = feedbackTypeId;
            Parameters = parameters;
        }

        public int FeedbackTypeId { get; private set; }

        public FeedbackTypeParameters Parameters { get; private set; }

        public IQueryable<FeedbackType> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<FeedbackType>().Where(new FeedbackTypeSpecification(FeedbackTypeId)); 
                              

            return q.OrderBy(x => x.FeedbackTypeId);
        }
    }
}
