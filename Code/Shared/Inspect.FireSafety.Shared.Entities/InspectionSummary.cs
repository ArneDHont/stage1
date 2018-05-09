using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Shared
{
    public class InspectionSummary
    {
        public int InspectionSummaryId { get; set; }
        public int OperatorId { get; set; }
        public User Operator { get; set; }
        public int? BackupOperatorId { get; set; }
        public User BackupOperator { get; set; }
        public int OrganisationUnitId { get; set; }
        public OrganisationUnit OrganisationUnit { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateFinished { get; set; }
        public bool Completed { get; set; }
        public int TotalToInspect { get; set; }
        public int TotalInspected { get; set; }
        public int TotalApproved { get; set; }
        public int TotalDisApproved { get; set; }
        public string Remarks { get; set; }
    }
    
}
