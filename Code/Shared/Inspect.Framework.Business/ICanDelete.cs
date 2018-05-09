namespace Inspect.Framework.Business
{
    public interface ICanDelete<TEntity> where TEntity : class
    {
        void Delete(TEntity entity);
    }
}