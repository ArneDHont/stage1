using Inspect.Framework.Data;
using System;
using System.Collections.Generic;

namespace Inspect.FireSafety.Shared
{
    public class Equipment : IObjectWithState
    {
        public long EquipmentId { get; set; }

        public int EquipmentTypeId { get; set; }

        public EquipmentType EquipmentType { get; set; }

        public int? EquipmentTypeConfigurationId { get; set; }

        public EquipmentTypeConfiguration EquipmentTypeConfiguration { get; set; }

        public EquipmentLocation EquipmentLocation { get; set; }

        public List<EquipmentIdentification> EquipmentIdentifications { get; set; }

        public int Number { get; set; }

        public string SerialNumber { get; set; }

        public double? Weight { get; set; }
        public int? BrandblusCodeID { get; set; }

        public DateTime? DateVisualInspection { get; set; }

        public IDictionary<string, object> OriginalValues { get; set; }

        public ObjectState State { get; set; }
    }
}