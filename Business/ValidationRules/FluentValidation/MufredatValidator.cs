using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MufredatValidator : AbstractValidator<Mufredat>
    {
        public MufredatValidator()
        {
            RuleFor(m => m.DersId).NotEmpty();
            RuleFor(m => m.MufredatId).NotEmpty();

        }
    }
}
