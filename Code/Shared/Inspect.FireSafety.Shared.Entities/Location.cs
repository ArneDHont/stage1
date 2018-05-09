using FluentValidation;
using FluentValidation.Attributes;

namespace Inspect.FireSafety.Shared
{
    [Validator(typeof(LocationValidator))]
    public class Location
    {
        public int LocationId { get; set; }

        public string Name { get; set; }
        public OrganisationUnit OrganisationUnit { get; set; }

        public int OrganisationUnitId { get; set; }
    }

    public class LocationValidator : AbstractValidator<Location>
    {
        public LocationValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(0, 4);
        }
    }
}