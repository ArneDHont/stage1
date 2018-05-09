using Inspect.FireSafety.Shared;
using System.Data.Entity.ModelConfiguration;

namespace Inspect.FireSafety.Data
{
    internal sealed class EquipmentEntityConfiguration : EntityTypeConfiguration<Shared.Equipment>
    {
        public EquipmentEntityConfiguration()
        {
            HasKey(x => x.EquipmentId);

            HasOptional(x => x.EquipmentLocation)
                .WithRequired(c => c.Equipment);
                        
            HasOptional(x => x.EquipmentTypeConfiguration);

            HasRequired(x => x.EquipmentType);
        }
    }
}