using Inspect.FireSafety.WebApi.Contracts.Equipment;
using Inspect.FireSafety.WebApi.EquipmentTypes;
using Inspect.Framework.Hypermedia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class EquipmentRepresentation : Representation
    {
        public DateTime? DateVisualInspection { get; set; }

        public long EquipmentId { get; set; }
        public List<EquipmentIdentificationRepresentation> EquipmentIdentifications { get; set; }
        [JsonIgnore]
        public EquipmentLocationRepresentation EquipmentLocation
        {
            get
            {
                return GetEmbedded<EquipmentLocationRepresentation>(HypermediaLinks.EquipmentLocation);
            }
            set
            {
                Embed(HypermediaLinks.EquipmentLocation, value, true);
            }
        }

        [JsonIgnore]
        public EquipmentTypeRepresentation EquipmentType
        {
            get
            {
                return GetEmbedded<EquipmentTypeRepresentation>(HypermediaLinks.EquipmentType);
            }
            set
            {
                Embed(HypermediaLinks.EquipmentType, value, true);
            }
        }

        public int EquipmentTypeId { get; set; }

        public int Number { get; set; }

        public string SerialNumber { get; set; }
        public double? weight { get; set; }
        public int? BrandblusCodeID { get; set; }
    }
}