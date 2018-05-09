using System;
using System.Linq.Expressions;

namespace Inspect.Framework.Data
{
    public interface IEntitySpecification<TEntity>
    {
        Expression<Func<TEntity, bool>> ToExpression();
    }
}