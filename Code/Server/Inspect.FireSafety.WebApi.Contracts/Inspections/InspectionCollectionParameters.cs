using System;

namespace Inspect.FireSafety.WebApi.Inspections
{
    public class InspectionCollectionParameters
    {
        public int LocationId { get; set; }

        public DateTime SelectedDate { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }
    }
}