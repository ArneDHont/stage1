using Inspect.FireSafety.Shared;
using System.Data.Entity.ModelConfiguration;

namespace Inspect.FireSafety.Data
{
    internal sealed class EquipmentTypeEntityConfiguration : EntityTypeConfiguration<EquipmentType>
    {
        public EquipmentTypeEntityConfiguration()
        {
            HasKey(x => x.EquipmentTypeId);

            HasMany(x => x.FeedbackTypes)
                .WithMany(x=>x.EquipmentTypes)
                .Map(m =>
                {
                    m.MapLeftKey("EquipmentTypeId");
                    m.MapRightKey("FeedbackTypeId");
                    m.ToTable("EquipmentTypeFeedbackLink");
                });
        }
    }
}