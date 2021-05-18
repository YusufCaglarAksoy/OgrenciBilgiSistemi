using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class IdareciValidator : AbstractValidator<Idareci>
    {
        public IdareciValidator()
        {
            RuleFor(i => i.SicilNo).NotEmpty().GreaterThan(10000).LessThan(100000);
            RuleFor(i => i.Isim).NotEmpty().MinimumLength(3).MaximumLength(25);
            RuleFor(i => i.Soyad).NotEmpty().MinimumLength(3).MaximumLength(25);
            RuleFor(i => i.EMail).NotEmpty().MinimumLength(5).MaximumLength(40);
            RuleFor(i => i.KayitTarihi).NotEmpty();
            RuleFor(i => i.TelefonNumarasi).NotEmpty().MinimumLength(10).MaximumLength(10);
        }
    }
}
