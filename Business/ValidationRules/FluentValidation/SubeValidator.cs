using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SubeValidator : AbstractValidator<Sube>
    {
        public SubeValidator()
        {
            RuleFor(s => s.DersId).NotEmpty();
            RuleFor(s => s.OgretmenId).NotEmpty();
        }
    }
}
