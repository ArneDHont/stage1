using System;
using System.Linq.Expressions;

namespace Inspect.Framework.Data.Builders.EntityQuery.Interfaces
{
    public interface IAdditionalSortDefinitionHolder<TEntity> where TEntity : class
    {
        IAdditionalSortDefinitionHolder<TEntity> AndThenBy<TProperty>(Expression<Func<TEntity, TProperty>> property);

        IAdditionalSortDefinitionHolder<TEntity> AndThenByDescending<TProperty>(Expression<Func<TEntity, TProperty>> property);

        IPageSizeHolder<TEntity> AndThenNoMoreSorting();
    }
}