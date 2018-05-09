using System;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class EquipmentCollectionParameters
    {
        public bool EmbedEquipmentLocation { get; set; } = true;

        public bool EmbedEquipmentType { get; set; } = true;

        public bool EmbedEquipmentTypeConfiguration { get; set; }

        public int[] EquipmentTypeId { get; set; }


        public int LocationId { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }

        public DateTime? VisualInspectionAfter { get; set; }

        public DateTime? VisualInspectionBefore { get; set; }

        public DateTime? SelectedDate { get; set; }

    }
}