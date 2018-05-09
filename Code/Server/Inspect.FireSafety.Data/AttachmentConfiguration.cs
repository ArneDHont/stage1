using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Data
{
    internal sealed class AttachmentConfiguration : EntityTypeConfiguration<Shared.Attachment>
    {
        public AttachmentConfiguration()
        {
            HasKey(x => x.AttachmentId);

            HasOptional(x => x.Binary)
                .WithRequired(x => x.Attachment);
            
            
        }
    }
}
