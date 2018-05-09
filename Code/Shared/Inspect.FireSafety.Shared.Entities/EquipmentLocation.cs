using FluentValidation;
using FluentValidation.Attributes;
using System;

namespace Inspect.FireSafety.Shared
{
    [Validator(typeof(EquipmentLocationValidator))]
    public class EquipmentLocation
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public Equipment Equipment { get; set; }

        public long EquipmentId { get; set; }

        public Location Location { get; set; }

        public int? LocationId { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public int OrderNumber { get; set; }

        public string Suffix { get; set; }
        
    }

    public class EquipmentLocationValidator : AbstractValidator<EquipmentLocation>
    {
        public EquipmentLocationValidator()
        {
            RuleFor(x => x.Code)
                .Length(0, 5);

            RuleFor(x => x.Name)
                .Length(0, 150);
        }
    }
}