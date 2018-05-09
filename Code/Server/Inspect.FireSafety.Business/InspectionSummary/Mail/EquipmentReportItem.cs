using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.InspectionSummary.Mail
{
    public class EquipmentReportItem
    {        
            public string Equipment { get; set; }
            public string LocationDescription { get; set; }
            public string QRCode { get; set; }
            public string FeedBack { get; set; }
            public string Remark { get; set; }
            public Boolean Vera { get; set; }        
    }
}
