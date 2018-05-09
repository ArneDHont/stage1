using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
    public class EquipmentModel
    {
        public DateTime? DateVisualInspection { get; set; }
        public long EquipmentId { get; set; }
        public LocationModel EquipmentLocation { get; set; }
        public TypeModel EquipmentType { get; set; }
        public List<EquipmentIdentificationModel> EquipmentIdentifications { get; set; }
        public int? BrandblusCodeID { get; set; }
        public int? LastFeedbackID { get; set; }


    }
}
