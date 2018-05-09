using Inspect.FireSafety.Shared;
using System.Data.Entity.ModelConfiguration;

namespace Inspect.FireSafety.Data
{
    internal sealed class OrganisationUnitEntityConfiguration : EntityTypeConfiguration<OrganisationUnit>
    {
        public OrganisationUnitEntityConfiguration()
        {
            HasKey(x => x.OrganisationUnitId);

            HasMany(x => x.Locations)
                .WithRequired(x => x.OrganisationUnit)
                .HasForeignKey(x => x.OrganisationUnitId);
        }
    }
}