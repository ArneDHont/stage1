using Inspect.Framework.Data;
using Inspect.Framework.Data.EntityFramework;

namespace Inspect.FireSafety.Data
{
    public class DataAccessComponentFactory
    {
        private static IDataAccessComponentFactory sFactory = new DefaultDataAccessComponentFactory();

        public static IDataAccessComponentFactory Instance
        {
            get
            {
                return sFactory;
            }
        }

        private class DefaultDataAccessComponentFactory : IDataAccessComponentFactory
        {
            public IDataAccessComponent Create()
            {
                return new DataAccessComponent(DbContextFactory.Instance);
            }
        }
    }
}