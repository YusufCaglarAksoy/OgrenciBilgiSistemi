using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class OgrenciValidator : AbstractValidator<Ogrenci>
    {
        public OgrenciValidator()
        {
            RuleFor(i => i.OgrenciNo).NotEmpty().GreaterThan(100000000).LessThan(1000000000);
            RuleFor(i => i.Isim).NotEmpty().MinimumLength(3).MaximumLength(25);
            RuleFor(i => i.Soyad).NotEmpty().MinimumLength(3).MaximumLength(25);
            RuleFor(i => i.EMail).NotEmpty().MinimumLength(5).MaximumLength(40);
            RuleFor(i => i.KayitTarihi).NotEmpty();
            RuleFor(i => i.TelefonNumarasi).NotEmpty().MinimumLength(10).MaximumLength(10);
            RuleFor(i => i.SubeKodu).NotEmpty().GreaterThan(1).LessThan(65);
            RuleFor(i => i.DanismanId).NotEmpty().GreaterThan(1).LessThan(20000);
            RuleFor(i => i.BolumId).NotEmpty().GreaterThan(1).LessThan(92);
        }
    }
}
