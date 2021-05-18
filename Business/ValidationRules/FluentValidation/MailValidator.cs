using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MailValidator : AbstractValidator<Mail>
    {
        public MailValidator()
        {
            RuleFor(m => m.MailBaslik).NotEmpty();
            RuleFor(m => m.MailBaslik).MinimumLength(3);
            RuleFor(m => m.MailBaslik).MaximumLength(50);
            RuleFor(m => m.MailText).NotEmpty();
            RuleFor(m => m.MailText).MinimumLength(5);
            RuleFor(m => m.MailText).MaximumLength(700);
            RuleFor(m => m.AliciMail).NotEmpty();
            RuleFor(m => m.AliciMail).MinimumLength(5);
            RuleFor(m => m.GonderenMail).NotEmpty();
            RuleFor(m => m.GonderenMail).MinimumLength(5);
        }
    }
}
