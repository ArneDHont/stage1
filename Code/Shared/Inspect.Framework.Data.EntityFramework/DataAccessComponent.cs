using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Inspect.Framework.Data.EntityFramework
{
    public partial class DataAccessComponent : IDataAccessComponent
    {
        public DataAccessComponent(IDbContextFactory contextFactory)
        {
            this.DbContextFactory = contextFactory;
        }

        protected IDbContextFactory DbContextFactory { get; private set; }

        public int Count<TEntity>(IEntityQuery<TEntity> query) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return query.Execute(context).Count();
            }
        }

        public int Count<TEntity>(IEntitySpecification<TEntity> specification = null) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return specification.SatisfyingItemsFrom(context.Set<TEntity>()).Count();
            }
        }

        public virtual TEntity Create<TEntity>(TEntity entity) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                context.ApplyChanges(entity);
                context.SaveChanges();
                return entity;
            }
        }

        public virtual void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                context.Set<TEntity>().Attach(entity);
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public TEntity Find<TEntity>(params object[] keyValues) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return context.Set<TEntity>().Find(keyValues);
            }
        }

        public TEntity FirstOrDefault<TEntity>(IEntityQuery<TEntity> query) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return query.Execute(context).FirstOrDefault();
            }
        }

        public TEntity FirstOrDefault<TEntity>(IEntitySpecification<TEntity> specification = null) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return specification.SatisfyingItemsFrom(context.Queryable<TEntity>()).FirstOrDefault();
            }
        }

        public TResult FirstOrDefault<TEntity, TResult>(IEntityProjection<TEntity, TResult> projection) where TEntity : class
        {
            using (var context = DbContextFactory.Create(emitOriginalValues: false))
            {
                return projection.Execute(context).FirstOrDefault();
            }
        }

        public IList<TEntity> Get<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                if (query == null)
                {
                    return context.Queryable<TEntity>().ToList();
                }
                else
                {
                    return query.Execute(context).ToList();
                }
            }
        }

        public IList<TEntity> Get<TEntity>(IEntitySpecification<TEntity> specification) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return specification.SatisfyingItemsFrom(context.Queryable<TEntity>()).ToList();
            }
        }

        public IList<TEntity> List<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class
        {
            using (var context = DbContextFactory.Create(emitOriginalValues: false))
            {
                if (query == null)
                {
                    return context.Queryable<TEntity>().ToList();
                }
                else
                {
                    return query.Execute(context).ToList();
                }
            }
        }

        public IList<TEntity> List<TEntity>(IEntitySpecification<TEntity> specification) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return specification.SatisfyingItemsFrom(context.Queryable<TEntity>()).ToList();
            }
        }

        public virtual TEntity SaveChanges<TEntity>(TEntity entity) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                context.ApplyChanges(entity);
                context.SaveChanges();
                return entity;
            }
        }

        public IEnumerable Select<TEntity>(IEntityProjection<TEntity> projection) where TEntity : class
        {
            using (var context = DbContextFactory.Create(emitOriginalValues: false))
            {
                ArrayList items = new ArrayList();
                foreach (var item in projection.Execute(context))
                {
                    items.Add(item);
                }
                return items;
            }
        }

        public IList<TResult> Select<TEntity, TResult>(IEntityProjection<TEntity, TResult> projection) where TEntity : class
        {
            using (var context = DbContextFactory.Create(emitOriginalValues: false))
            {
                return projection.Execute(context).ToList();
            }
        }

        public TResult Select<TEntity, TResult>(IEntityScalarProjection<TEntity, TResult> projection) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return projection.Execute(context);
            }
        }

        public TResult SingleOrDefault<TEntity, TResult>(IEntityProjection<TEntity, TResult> projection) where TEntity : class
        {
            using (var context = DbContextFactory.Create(emitOriginalValues: false))
            {
                return projection.Execute(context).SingleOrDefault();
            }
        }

        public TEntity SingleOrDefault<TEntity>(IEntityQuery<TEntity> query) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return query.Execute(context).SingleOrDefault();
            }
        }

        public TEntity SingleOrDefault<TEntity>(IEntitySpecification<TEntity> specification = null) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                return specification.SatisfyingItemsFrom(context.Queryable<TEntity>()).SingleOrDefault();
            }
        }

        public virtual TEntity Update<TEntity>(TEntity entity) where TEntity : class
        {
            using (var context = DbContextFactory.Create())
            {
                context.ApplyChanges(entity);
                context.SaveChanges();
                return entity;
            }
        }
    }
}