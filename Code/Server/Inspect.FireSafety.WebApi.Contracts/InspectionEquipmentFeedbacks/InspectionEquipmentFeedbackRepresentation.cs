using Inspect.FireSafety.WebApi.FeedbackTypes;
using Inspect.FireSafety.WebApi.Users;
using Inspect.Framework.Hypermedia;
using Newtonsoft.Json;
using System;

namespace Inspect.FireSafety.WebApi.EquipmentFeedbacks
{
    public class InspectionEquipmentFeedbackRepresentation : Representation
    {
        public int InspectionEquipmentFeedbackId { get; set; }
        public long EquipmentId { get; set; }

        public string Status { get; set; }
        public int? FeedbackTypeId { get; set; }

        [JsonIgnore]
        public FeedbackTypeRepresentation FeedbackType
        {
            get
            {
                return GetEmbedded<FeedbackTypeRepresentation>(nameof(FeedbackType));
            }
            set
            {
                Embed(nameof(FeedbackType), value, true);
            }
        }

        public string Remark { get; set; }
        public DateTime TimeCompleted { get; set; }
        public int OperatorId { get; set; }

        [JsonIgnore]
        public UserRepresentation Operator
        {
            get
            {
                return GetEmbedded<UserRepresentation>(nameof(Operator));
            }
            set
            {
                Embed(nameof(Operator), value, true);
            }
        }

        public string EquipmentLocationName { get; set; }
        public string EquipmentLocationDescription { get; set; }
        public bool Vera { get; set; }
        public double? Weight { get; set; }
    }
}