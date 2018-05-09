using Inspect.FireSafety.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Data
{
    internal sealed class FeedbackTypeEntityConfiguration : EntityTypeConfiguration<FeedbackType>
    {
        public FeedbackTypeEntityConfiguration()
        {
            HasKey(x => x.FeedbackTypeId);
        }
    }
}
