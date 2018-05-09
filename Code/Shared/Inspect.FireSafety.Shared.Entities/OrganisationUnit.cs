using FluentValidation;
using FluentValidation.Attributes;
using System.Collections.Generic;

namespace Inspect.FireSafety.Shared
{
    [Validator(typeof(OrganisationValidator))]
    public class OrganisationUnit
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int OrganisationUnitId { get; set; }

        public IList<Location> Locations { get; set; }
    }

    public class OrganisationValidator : AbstractValidator<OrganisationUnit>
    {
        public OrganisationValidator()
        {
            RuleFor(x => x.Code)
                .NotNull()
                .Length(0, 10);

            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(0, 50);
        }
    }
}