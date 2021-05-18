using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class DevamsizlikValidator : AbstractValidator<Devamsizlik>
    {
        public DevamsizlikValidator()
        {
            RuleFor(d => d.DersId).NotEmpty();
            RuleFor(d => d.DevamsizlikDurumu).NotEmpty();
            RuleFor(d => d.OgrenciId).NotEmpty();
        }
    }
}
