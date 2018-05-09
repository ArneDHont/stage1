using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.InspectionEquipmentFeedbacks
{
    public class InspectionEquipmentFeedbackAttachmentRepresentationForCreation
    {
        public int AttachmentId { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
