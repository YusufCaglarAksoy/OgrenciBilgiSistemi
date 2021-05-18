using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class DersValidator : AbstractValidator<Ders>
    {
        public DersValidator()
        {
            RuleFor(d => d.DersKodu).NotEmpty();
            RuleFor(d => d.DersKodu).MaximumLength(6);
            RuleFor(d => d.DersKodu).MinimumLength(6);
            RuleFor(d => d.DersAdi).NotEmpty();
            RuleFor(d => d.DersAdi).MaximumLength(40);
            RuleFor(d => d.DonemId).NotEmpty();
            RuleFor(d => d.Sinif).NotEmpty();
            RuleFor(d => d.BolumId).NotEmpty();
        }
    }
}
