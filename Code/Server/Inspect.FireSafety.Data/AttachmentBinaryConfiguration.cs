using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Data
{
    internal sealed class AttachmentBinaryConfiguration : EntityTypeConfiguration<Shared.AttachmentBinary>
    {
        public AttachmentBinaryConfiguration()
        {
            HasKey(x => x.AttachmentId);

        }
    }
}
