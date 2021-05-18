using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SinavValidator : AbstractValidator<Sinav>
    {
        public SinavValidator()
        {
            RuleFor(s => s.SinavTarihi).NotEmpty();
            RuleFor(s => s.SinavTurId).NotEmpty();
            RuleFor(s => s.DersId).NotEmpty();
        }
    }
}
