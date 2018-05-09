namespace Inspect.Framework.Data.Builders.EntityQuery.Interfaces
{
    public interface IPageSizeHolder<TEntity> where TEntity : class
    {
        IPageNumberHolder<TEntity> WithPageSize(int pageSize);

        IEagerLoadingHolder<TEntity> WithoutPaging();
    }
}