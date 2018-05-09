namespace Inspect.Framework.Data.Builders.EntityQuery.Interfaces
{
    public interface IEntityQueryBuilder<TEntity> where TEntity : class
    {
        IEntityQuery<TEntity> Build();
    }
}