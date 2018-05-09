using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
    public class InspectionCompleteMessage
    {
        public long EquipmentId { get; private set; }

        public FeedbackTypeModel FeedbackType { get; private set; }

        public string Remarks { get; private set; }

        public bool Vera { get; private set; }
        public double? Weight { get; set; }
        public ObservableCollection<MediaFile> Photos { get; private set; }
        public InspectionResult Result { get; private set; }

        public InspectionCompleteMessage(long equipmentId, double? weight, InspectionResult result)
        {
            EquipmentId = equipmentId;
            Result = result;
            Weight = weight;
            
        }

        public InspectionCompleteMessage(long equipmentId, InspectionResult result, FeedbackTypeModel feedbackType, string remarks,bool vera, ObservableCollection<MediaFile> photos, double? weight)
        {
            EquipmentId = equipmentId;
            Result = result;
            FeedbackType = feedbackType;
            Remarks = remarks;
            Vera = vera;
            Photos = photos;
            Weight = weight;
        }
    }

    public enum InspectionResult
    {
        Ok,
        Cancel,
        NotOk
    }
}
