namespace Inspect.Framework.Data.EntityFramework
{
    public interface IDbContextFactory
    {
        IDbContextBase Create(bool emitOriginalValues = true);
    }
}