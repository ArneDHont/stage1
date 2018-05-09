using Inspect.FireSafety.Shared;
using System.Data.Entity.ModelConfiguration;

namespace Inspect.FireSafety.Data
{
    internal sealed class MediumEntityConfiguration : EntityTypeConfiguration<Medium>
    {
        public MediumEntityConfiguration()
        {
            HasKey(x => x.MediumId);
        }
    }
}