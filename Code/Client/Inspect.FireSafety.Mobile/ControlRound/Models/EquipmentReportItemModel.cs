
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
    public class EquipmentReportItemModel 
    {
        public string Equipment { get; set; }
        public string LocationDescription { get; set; }
        public string QRCode { get; set; }
        public string FeedBack { get; set; }
        public string Remark { get; set; }
        public bool Vera { get; set; }
    }
}
