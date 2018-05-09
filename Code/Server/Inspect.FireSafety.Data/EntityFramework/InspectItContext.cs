using Inspect.Framework.Data;
using Inspect.Framework.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Inspect.FireSafety.Data
{
    internal static class DbModelBuilderExtensions
    {
        public static void IgnoreObjectWithStateProperties(this DbModelBuilder modelBuilder)
        {
            modelBuilder.Types()
                .Where(t => ShouldIgnoreObjectWithStateProperties(t))
                .Configure(c =>
                {
                    c.Ignore(nameof(IObjectWithState.State));
                    c.Ignore(nameof(IObjectWithState.OriginalValues));
                });
        }

        private static bool ShouldIgnoreObjectWithStateProperties(Type type)
        {
            return typeof(IObjectWithState).IsAssignableFrom(type) && !typeof(IObjectWithState).IsAssignableFrom(type.BaseType);
        }
    }

    public class InspectItContext : DbContextBase
    {
        public InspectItContext() : base()
        {
        }

        public InspectItContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public InspectItContext(bool emitOriginalValues) : base(emitOriginalValues: emitOriginalValues)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("db_inspect");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Load all EntityTypeConfiguration that are available in this assembly (ModelConfiguration).
            modelBuilder.Configurations.AddFromAssembly(typeof(InspectItContext).Assembly);

            // Version of IObjectWithVersion should be configured as row version.
            modelBuilder.Types<IObjectWithVersion>().Configure(c => c.Property(p => p.Version).IsRowVersion());
            
            // Properties of IObjectWithState should be ignored
            modelBuilder.IgnoreObjectWithStateProperties();
        }
    }
}