using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Data
{
    internal sealed class InspectionSummary : EntityTypeConfiguration<Shared.InspectionSummary>
    {
        public InspectionSummary()
        {
            HasKey(x => x.InspectionSummaryId);           

            HasRequired(x => x.Operator)
                .WithMany()
                .HasForeignKey(x => x.OperatorId); 

            HasOptional(x => x.BackupOperator)
                .WithMany()
                .HasForeignKey(x => x.BackupOperatorId);



        }
    }
}
