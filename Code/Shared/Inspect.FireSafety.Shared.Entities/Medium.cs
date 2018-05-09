using FluentValidation;
using FluentValidation.Attributes;

namespace Inspect.FireSafety.Shared
{
    [Validator(typeof(MediumValidator))]
    public class Medium
    {
        public int MediumId { get; set; }

        public string Name { get; set; }
    }

    public class MediumValidator : AbstractValidator<Medium>
    {
        public MediumValidator()
        {
            RuleFor(x => x.Name)
                .Length(0, 50);
        }
    }
}