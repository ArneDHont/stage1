using System;
using System.Linq;
using System.Linq.Expressions;

namespace Inspect.Framework.Data
{
    /// <remarks>
    /// We want to decouple our data access layer from EntityFramework so we need to implement our own Include() methods.
    /// The default include methods are implemented in enitty framework and not on IQueryable, however
    /// we would like to expose this method by our data access layer to the business layer.
    /// 
    /// The DbContextBase uses the EntityFrameworkQueryable wrapper class to achieve correct seperation between data access
    /// and business.
    /// </remarks>
    public static class QueryableExtensions
    {
        public static IQueryable<TObject> Include<TObject>(this IQueryable<TObject> queryable, string path)
        {
            if (queryable is IDataAccessQueryable<TObject>)
            {
                return ((IDataAccessQueryable<TObject>)queryable).Include(path);
            }
            else
            {
                return queryable;
            }
        }

        public static IQueryable<TObject> Include<TObject, TProperty>(this IQueryable<TObject> queryable, Expression<Func<TObject, TProperty>> path)
        {
            if (queryable is IDataAccessQueryable<TObject>)
            {
                return ((IDataAccessQueryable<TObject>)queryable).Include(path);
            }
            else
            {
                return queryable;
            }
        }

        public static IQueryable<TObject> Paging<TObject>(this IQueryable<TObject> instance, int pageNumber, int pageSize)
        {
            int skipItems = (pageNumber - 1) * pageSize;
            return instance.Skip(skipItems).Take(pageSize);
        }

        public static IQueryable<TObject> Where<TObject>(this IQueryable<TObject> queryable, IEntitySpecification<TObject> specification)
        {
            return specification.SatisfyingItemsFrom(queryable);
        }
    }
}