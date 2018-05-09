using Inspect.Framework.Data.EntityFramework;

namespace Inspect.FireSafety.Data
{
    public class DbContextFactory
    {
        private static IDbContextFactory sFactory = new DefaultContextFactory();

        public static IDbContextFactory Instance
        {
            get
            {
                return sFactory;
            }
        }

        private class DefaultContextFactory : IDbContextFactory
        {
            public IDbContextBase Create(bool emitOriginalValues = true)
            {
                var context = new InspectItContext(emitOriginalValues);                
                return context;
            }
        }
    }
}