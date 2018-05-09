using System.Linq;

namespace Inspect.Framework.Data
{
    public interface IEntityQueryModel
    {
        IQueryable<TEntity> Queryable<TEntity>() where TEntity : class;
    }
}