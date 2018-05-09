namespace Inspect.Framework.Business
{
    public interface ICanCreate<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
    }
}