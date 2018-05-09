using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.Contracts.InspectionSummary
{
    public class InspectionSummaryRepresentation: Representation
    {
        public int InspectionSummaryId { get; set; }
        public int OperatorId { get; set; }
        public Users.UserRepresentation Operator { get; set; }
        public int? BackupOperatorId { get; set; }
        public Users.UserRepresentation BackupOperator { get; set; }
        public int OrganisationUnitId { get; set; }
        public int LocationId { get; set; }
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

