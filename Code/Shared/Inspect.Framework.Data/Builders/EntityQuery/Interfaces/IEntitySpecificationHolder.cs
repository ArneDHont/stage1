namespace Inspect.Framework.Data.Builders.EntityQuery.Interfaces
{
    public interface IEntitySpecificationHolder<TEntity> where TEntity : class
    {
        ISortDefinitionHolder<TEntity> WithSpecification(IEntitySpecification<TEntity> specification);
    }
}