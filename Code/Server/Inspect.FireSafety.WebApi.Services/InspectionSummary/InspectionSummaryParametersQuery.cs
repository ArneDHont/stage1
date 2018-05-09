using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.InspectionSummary
{
    public class InspectionSummaryParametersQuery : IEntityQuery<Shared.InspectionSummary>
    {
        public InspectionSummaryParametersQuery(int inspectionSummaryId)
        {
            InspectionSummaryId= inspectionSummaryId;
        }

        public int InspectionSummaryId { get; private set; }

        public IQueryable<Shared.InspectionSummary> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<Shared.InspectionSummary>().Where(x => x.InspectionSummaryId == InspectionSummaryId);            
            q = q.Include(x => x.Operator);
            q = q.Include(x => x.BackupOperator);
            q = q.Include(x => x.OrganisationUnit);
            q = q.Include(x => x.Location);
            return q;
        }
    }
}
