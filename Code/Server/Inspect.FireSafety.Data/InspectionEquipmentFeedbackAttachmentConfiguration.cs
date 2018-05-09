using Inspect.FireSafety.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Data
{
    internal class InspectionEquipmentFeedbackAttachmentConfiguration : EntityTypeConfiguration<InspectionEquipmentFeedbackAttachment>
    {
        public InspectionEquipmentFeedbackAttachmentConfiguration()
        {
            ToTable(nameof(InspectionEquipmentFeedbackAttachment));

            HasRequired(x => x.InspectionEquipmentFeedback);
        }
    }
}
