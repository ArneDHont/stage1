using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.Framework.Data.Builders.EntityQuery.Interfaces
{
    public interface ISortDefinitionHolder<TEntity> where TEntity : class
    {
        IAdditionalSortDefinitionHolder<TEntity> WithOrderBy<TProperty>(Expression<Func<TEntity, TProperty>> property);

        IAdditionalSortDefinitionHolder<TEntity> WithOrderByDescending<TProperty>(Expression<Func<TEntity, TProperty>> property);

        IEagerLoadingHolder<TEntity> WithNoSorting();
    }
}
