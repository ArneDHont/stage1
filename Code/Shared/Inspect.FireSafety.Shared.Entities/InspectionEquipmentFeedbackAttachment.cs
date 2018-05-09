using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Shared
{
    public class InspectionEquipmentFeedbackAttachment : Attachment
    {
        public int InspectionEquipmentFeedbackId { get; set; }
        public InspectionEquipmentFeedback InspectionEquipmentFeedback { get; set; }
    }
}
