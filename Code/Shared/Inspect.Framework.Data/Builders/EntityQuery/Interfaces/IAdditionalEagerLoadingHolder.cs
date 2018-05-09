namespace Inspect.Framework.Data.Builders.EntityQuery.Interfaces
{
    public interface IAdditionalEagerLoadingHolder<TEntity> where TEntity : class
    {
        IAdditionalEagerLoadingHolder<TEntity> AndEagerLoading(string path);

        IEntityQueryBuilder<TEntity> AndNoMoreEagerLoading();
    }
}