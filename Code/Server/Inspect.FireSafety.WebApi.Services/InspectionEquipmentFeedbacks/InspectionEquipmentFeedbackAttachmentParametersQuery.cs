using System;
using System.Linq;
using System.Linq.Expressions;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;

namespace Inspect.FireSafety.WebApi.EquipmentFeedbacks
{
    internal class InspectionEquipmentFeedbackAttachmentParametersQuery : IEntityQuery<Shared.Attachment>
    {
        private int id;
        private InspectionEquipmentFeedbackParameters parameters;

        public InspectionEquipmentFeedbackAttachmentParametersQuery(int id, InspectionEquipmentFeedbackParameters parameters)
        {
            this.id = id;
            this.parameters = parameters;
        }

        
        IQueryable<Attachment> IEntityQuery<Attachment>.Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<Attachment>().Where(x => x.AttachmentId == id);
            return q;
        }
    }
}