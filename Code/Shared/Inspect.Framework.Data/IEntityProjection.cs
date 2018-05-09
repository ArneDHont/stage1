using System.Linq;

namespace Inspect.Framework.Data
{
    public interface IEntityProjection<TEntity>
    {
        IQueryable Execute(IEntityQueryModel db);
    }

    public interface IEntityProjection<TEntity, TResult>
    {
        IQueryable<TResult> Execute(IEntityQueryModel db);
    }
}