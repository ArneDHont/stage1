using System.Collections;
using System.Collections.Generic;

namespace Inspect.Framework.Data
{
    public partial interface IDataAccessComponent
    {
        int Count<TEntity>(IEntityQuery<TEntity> query) where TEntity : class;

        int Count<TEntity>(IEntitySpecification<TEntity> specification = null) where TEntity : class;

        TEntity Create<TEntity>(TEntity entity) where TEntity : class;

        void Delete<TEntity>(TEntity entity) where TEntity : class;

        TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;

        TEntity FirstOrDefault<TEntity>(IEntityQuery<TEntity> query) where TEntity : class;

        TEntity FirstOrDefault<TEntity>(IEntitySpecification<TEntity> specification = null) where TEntity : class;

        TResult FirstOrDefault<TEntity, TResult>(IEntityProjection<TEntity, TResult> projection) where TEntity : class;

        IList<TEntity> Get<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class;

        IList<TEntity> Get<TEntity>(IEntitySpecification<TEntity> query) where TEntity : class;

        IList<TEntity> List<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class;

        IList<TEntity> List<TEntity>(IEntitySpecification<TEntity> specification) where TEntity : class;

        TEntity SaveChanges<TEntity>(TEntity entity) where TEntity : class;

        IEnumerable Select<TEntity>(IEntityProjection<TEntity> projection) where TEntity : class;

        TResult Select<TEntity, TResult>(IEntityScalarProjection<TEntity, TResult> projection) where TEntity : class;

        IList<TResult> Select<TEntity, TResult>(IEntityProjection<TEntity, TResult> projection) where TEntity : class;

        TEntity SingleOrDefault<TEntity>(IEntityQuery<TEntity> query) where TEntity : class;

        TEntity SingleOrDefault<TEntity>(IEntitySpecification<TEntity> specification = null) where TEntity : class;

        TResult SingleOrDefault<TEntity, TResult>(IEntityProjection<TEntity, TResult> projection) where TEntity : class;

        TEntity Update<TEntity>(TEntity entity) where TEntity : class;
    }
}