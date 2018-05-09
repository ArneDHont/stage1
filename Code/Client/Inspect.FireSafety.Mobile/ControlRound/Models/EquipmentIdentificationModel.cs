using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
    public class EquipmentIdentificationModel
    {
        public long EquipmentIdentificationId { get; set; }
        public long EquipmentId { get; set; }
        public string Value { get; set; }
    }
}
