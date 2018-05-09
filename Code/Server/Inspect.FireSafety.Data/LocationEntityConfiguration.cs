using Inspect.FireSafety.Shared;
using System.Data.Entity.ModelConfiguration;

namespace Inspect.FireSafety.Data
{
    internal sealed class LocationEntityConfiguration : EntityTypeConfiguration<Location>
    {
        public LocationEntityConfiguration()
        {
            HasKey(x => x.LocationId);
        }
    }
}