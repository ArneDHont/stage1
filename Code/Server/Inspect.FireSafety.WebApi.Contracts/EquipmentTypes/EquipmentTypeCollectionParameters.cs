namespace Inspect.FireSafety.WebApi.EquipmentTypes
{
    public class EquipmentTypeCollectionParameters
    {
        public string[] Code { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }
    }
}