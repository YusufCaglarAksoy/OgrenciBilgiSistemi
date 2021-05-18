using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class HarcValidator : AbstractValidator<Harc>
    {
        public HarcValidator()
        {
            RuleFor(h => h.OgrenciId).NotEmpty();
            RuleFor(h => h.Donem).NotEmpty();
            RuleFor(h => h.Tipi).NotEmpty();
            RuleFor(h => h.Turu).NotEmpty();
            RuleFor(h => h.TahakkukTarihi).NotEmpty();
            RuleFor(h => h.OdemeTarihi).NotEmpty();
            RuleFor(h => h.Tutar).NotEmpty();
            RuleFor(h => h.Tutar).LessThan(0).WithMessage("Tutar 0 dan büyük olmalıdır");
            RuleFor(h => h.Donem).InclusiveBetween(1, 3);
        }
    }
}
