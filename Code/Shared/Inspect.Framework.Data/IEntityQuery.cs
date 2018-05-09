using System.Linq;

namespace Inspect.Framework.Data
{
    public interface IEntityQuery<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Execute(IEntityQueryModel db);
    }
}