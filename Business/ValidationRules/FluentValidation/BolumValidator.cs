using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BolumValidator : AbstractValidator<Bolum>
    {
        public BolumValidator()
        {
            RuleFor(f => f.BolumAdi).NotEmpty();
            RuleFor(f => f.BolumAdi).MaximumLength(60);
        }
    }
}
