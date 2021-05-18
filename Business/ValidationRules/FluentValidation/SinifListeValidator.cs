using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SinifListeValidator : AbstractValidator<SinifListe>
    {
        public SinifListeValidator()
        {
            RuleFor(sl => sl.SubeId).NotEmpty();
            RuleFor(sl => sl.OgrenciId).NotEmpty();
        }
    }
}
