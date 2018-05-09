using FluentValidation;
using FluentValidation.Attributes;

namespace Inspect.FireSafety.Shared
{
    [Validator(typeof(EquipmentTypeConfigurationValidator))]
    public class EquipmentTypeConfiguration
    {
        public EquipmentType EquipmentType { get; set; }

        public int EquipmentTypeConfigurationId { get; set; }

        public int EquipmentTypeId { get; set; }

        public Medium Medium { get; set; }

        public int? MediumId { get; set; }

        public string Name { get; set; }

        public byte? Weight { get; set; }
    }

    public class EquipmentTypeConfigurationValidator : AbstractValidator<EquipmentTypeConfiguration>
    {
        public EquipmentTypeConfigurationValidator()
        {
            RuleFor(x => x.Name)
                .Length(0, 50);
        }
    }
}