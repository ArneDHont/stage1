using Inspect.FireSafety.Shared;
using System.Data.Entity.ModelConfiguration;

namespace Inspect.FireSafety.Data
{
    internal sealed class EquipmentLocationEntityConfiguration : EntityTypeConfiguration<EquipmentLocation>
    {
        public EquipmentLocationEntityConfiguration()
        {
            HasKey(x => x.EquipmentId);

            HasRequired(x => x.Location);
        }
    }
}