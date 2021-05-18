using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class NotValidator : AbstractValidator<Not>
    {
        public NotValidator()
        {
            RuleFor(n => n.SinavNot).GreaterThanOrEqualTo(0);
            RuleFor(n => n.SinavNot).InclusiveBetween<Not, int>(0, 100); 
            RuleFor(n => n.SinavId).NotEmpty();
            RuleFor(n => n.SinavNot).NotEmpty();
            RuleFor(n => n.OgrenciId).NotEmpty();
        }
    }
}
