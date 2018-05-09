using FluentValidation;
using FluentValidation.Attributes;
using System.Collections.Generic;

namespace Inspect.FireSafety.Shared
{
    [Validator(typeof(EquipmentTypeValidator))]
    public class EquipmentType
    {
        public int EquipmentTypeId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public IList<FeedbackType> FeedbackTypes { get; set; }
    }

    public class EquipmentTypeValidator : AbstractValidator<EquipmentType>
    {
        public EquipmentTypeValidator()
        {
            RuleFor(x => x.Name)
                .Length(0, 50);
        }
    }
}