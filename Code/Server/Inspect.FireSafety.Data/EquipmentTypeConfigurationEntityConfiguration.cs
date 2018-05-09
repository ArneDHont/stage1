using Inspect.FireSafety.Shared;
using System.Data.Entity.ModelConfiguration;

namespace Inspect.FireSafety.Data
{
    internal sealed class EquipmentTypeConfigurationEntityConfiguration : EntityTypeConfiguration<EquipmentTypeConfiguration>
    {
        public EquipmentTypeConfigurationEntityConfiguration()
        {
            HasKey(x => x.EquipmentTypeConfigurationId);

            HasRequired(x => x.EquipmentType);

            HasOptional(x => x.Medium);
        }
    }
}