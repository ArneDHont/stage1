namespace Inspect.Framework.Business
{
    public interface ICanUpdate<TEntity> where TEntity : class
    {
        TEntity Update(TEntity entity);
    }
}