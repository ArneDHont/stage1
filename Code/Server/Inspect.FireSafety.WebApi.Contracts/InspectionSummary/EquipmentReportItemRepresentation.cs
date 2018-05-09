using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.InspectionSummary
{
    public class EquipmentReportItemRepresentation : Representation
    {
        public string Equipment { get; set; }
        public string LocationDescription { get; set; }
        public string QRCode { get; set; }
        public string FeedBack { get; set; }
        public string Remark { get; set; }
        public bool Vera { get; set; }
    }
}
