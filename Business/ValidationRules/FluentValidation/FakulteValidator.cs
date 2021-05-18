using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class FakulteValidator : AbstractValidator<Fakulte>
    {
        public FakulteValidator()
        {
            RuleFor(f => f.FakulteAdi).NotEmpty();
            RuleFor(f => f.FakulteAdi).MaximumLength(60);
        }
    }
}
