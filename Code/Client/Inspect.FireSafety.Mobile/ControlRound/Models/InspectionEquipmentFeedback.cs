using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
     public class InspectionEquipmentFeedback
    {
        private string remark;
        private int? feedbackTypeId;

        public bool Vera { get; set; }

        public int InspectionEquipmentFeedbackId { get; set; }
        public long EquipmentId { get; set; }
        public EquipmentModel Equipment { get; set; }
        public string Status { get; set; }
        public int? FeedbackTypeId {
            get { return feedbackTypeId; }
            set
            {
                feedbackTypeId = value;
                if (feedbackTypeId.HasValue) FeedbackVisible = true;
                else FeedbackVisible = false;
            }
        }
        public bool FeedbackVisible { get; set; } = false;
        public FeedbackTypeModel FeedbackType { get; set; }
        public string Remark {
            get { return remark; }
            set { remark = value;
                if (value != null) RemarkVisible = true;
                else RemarkVisible = false;
            }
        }
        public bool RemarkVisible { get; set; } = false;
        public DateTime TimeCompleted { get; set; }
        public int OperatorId { get; set; }
        public UserModel Operator { get; set; }
        public string EquipmentLocationName { get; set; }
        public string EquipmentLocationDescription { get; set; }
        public bool IsVisible { get; set; }

    }
}
