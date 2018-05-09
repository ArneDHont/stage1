using Inspect.FireSafety.Business.EquipmentFeedbacks;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.EquipmentFeedbacks
{
    public class InspectionEquipmentFeedbackParametersQuery : IEntityQuery<InspectionEquipmentFeedback>
    {
        public InspectionEquipmentFeedbackParametersQuery(int equipmentFeedbackId,InspectionEquipmentFeedbackParameters parameters = null)
        {
            EquipmentFeedbackId = equipmentFeedbackId;
            Parameters = parameters;
        }

        public int EquipmentFeedbackId { get; private set; }
        public InspectionEquipmentFeedbackParameters Parameters { get; private set; }

        public IQueryable<InspectionEquipmentFeedback> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<InspectionEquipmentFeedback>().Where(x => x.InspectionEquipmentFeedbackId == EquipmentFeedbackId);
            return q;
        }
    }
}
