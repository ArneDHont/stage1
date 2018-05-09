namespace Inspect.Framework.Data.Builders.EntityQuery.Interfaces
{
    public interface IPageNumberHolder<TEntity> where TEntity : class
    {
        IEagerLoadingHolder<TEntity> WithPageNumber(int pageIndex);
    }
}