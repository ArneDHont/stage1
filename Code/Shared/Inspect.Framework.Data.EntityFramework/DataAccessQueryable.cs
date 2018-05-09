using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Inspect.Framework.Data.EntityFramework
{
    internal class DataAccessQueryable<TEntity> : IDataAccessQueryable<TEntity>, IQueryable<TEntity>, IEnumerable<TEntity>, IOrderedQueryable<TEntity>, IQueryable, IEnumerable
    {
        private IQueryable<TEntity> mOrigin;

        private IQueryProvider mProvider;

        public DataAccessQueryable(IQueryable<TEntity> origin)
        {
            mOrigin = origin;
            mProvider = new DataAccessQueryProvider(origin.Provider);
        }

        public Type ElementType
        {
            get
            {
                return mOrigin.ElementType;
            }
        }

        public Expression Expression
        {
            get
            {
                return mOrigin.Expression;
            }
        }

        public IQueryProvider Provider
        {
            get
            {
                return mProvider;
            }
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return mOrigin.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mOrigin.GetEnumerator();
        }

        IQueryable<TEntity> IDataAccessQueryable<TEntity>.Include(string path)
        {
            return new DataAccessQueryable<TEntity>(System.Data.Entity.QueryableExtensions.Include(mOrigin, path));
        }

        IQueryable<TEntity> IDataAccessQueryable<TEntity>.Include<TProperty>(Expression<Func<TEntity, TProperty>> path)
        {
            return new DataAccessQueryable<TEntity>(System.Data.Entity.QueryableExtensions.Include(mOrigin, path));
        }
    }
}