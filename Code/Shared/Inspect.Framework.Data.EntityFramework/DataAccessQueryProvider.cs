using System.Linq;
using System.Linq.Expressions;

namespace Inspect.Framework.Data.EntityFramework
{
    internal class DataAccessQueryProvider : IQueryProvider
    {
        private IQueryProvider mOrigin;

        public DataAccessQueryProvider(IQueryProvider origin)
        {
            mOrigin = origin;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            return mOrigin.CreateQuery(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            var query = mOrigin.CreateQuery<TElement>(expression);
            return new DataAccessQueryable<TElement>(query);
        }

        public object Execute(Expression expression)
        {
            return mOrigin.Execute(expression);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return mOrigin.Execute<TResult>(expression);
        }
    }
}