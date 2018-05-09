using Inspect.FireSafety.WebApi.Equipment;
using Inspect.FireSafety.WebApi.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.FireSafety.WebApi.InspectionEquipmentFeedbacks
{
    public class InspectionEquipmentFeedbackRepresentationForCreation
    {
        public long EquipmentId { get; set; }
        public string Status { get; set; }
        public int? FeedbackTypeId { get; set; }
        public string Remark { get; set; }
        public DateTime TimeCompleted { get; set; }
        public int OperatorId { get; set; }
        public string EquipmentLocationName { get; set; }
        public string EquipmentLocationDescription { get; set; }
        public bool Vera { get; set; }
        public double? Weight { get; set; }

    }
}
