using Inspect.FireSafety.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Data
{
    internal sealed class InspectionEquipmentFeedback : EntityTypeConfiguration<Shared.InspectionEquipmentFeedback>
    {
        public InspectionEquipmentFeedback()
        {
            HasKey(x => x.InspectionEquipmentFeedbackId);

            HasRequired(x => x.Operator)
                .WithMany()
                .HasForeignKey(x => x.OperatorId);

            HasMany(x => x.Attachments);
               

            HasOptional(x => x.FeedbackType);





        }
    }
}
