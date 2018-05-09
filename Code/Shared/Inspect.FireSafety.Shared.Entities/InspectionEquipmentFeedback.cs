using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Shared
{
    public class InspectionEquipmentFeedback : IObjectWithState
    {
        public InspectionEquipmentFeedback()
        {
            Attachments = new List<InspectionEquipmentFeedbackAttachment>();
        }
        public int InspectionEquipmentFeedbackId { get; set; }
        public long EquipmentId { get; set; }
        public string Status { get; set; }
        public int? FeedbackTypeId { get; set; }
        public FeedbackType FeedbackType { get; set; }
        public string Remark { get; set; }
        public DateTime TimeCompleted { get; set; }
        public int OperatorId { get; set; }
        public User Operator { get; set; }
        public string EquipmentLocationName { get; set; }
        public string EquipmentLocationDescription { get; set; }
        public bool Vera { get; set; }
        public double? Weight { get; set; }

        public IList<InspectionEquipmentFeedbackAttachment> Attachments { get; set; }
        public IDictionary<string, object> OriginalValues { get; set; }
        public ObjectState State { get; set; }
    }
}
