using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System.Linq;

namespace Inspect.FireSafety.WebApi.FeedbackTypes
{
    public class FeedbackTypeCollectionParametersQuery : IEntityQuery<FeedbackType>
    {
        public FeedbackTypeCollectionParametersQuery(FeedbackTypeCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public FeedbackTypeCollectionParameters Parameters { get; private set; }

        public IQueryable<FeedbackType> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<FeedbackType>();

            q = q.OrderBy(x => x.FeedbackTypeId);
                        

            return q;
        }
    }
}
