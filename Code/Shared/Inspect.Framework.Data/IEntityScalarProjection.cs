namespace Inspect.Framework.Data
{
    public interface IEntityScalarProjection<TEntity, TResult>
    {
        TResult Execute(IEntityQueryModel db);
    }
}