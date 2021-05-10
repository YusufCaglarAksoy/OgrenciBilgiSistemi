using Core.Entities;

namespace Entities.Concrete
{
    public class Mail : IEntity
    {
        public string MailId { get; set; }
        public string MailBaslik { get; set; }
        public string MailText { get; set; }
        public string AlıcıMail { get; set; }
        public string GonderenMail { get; set; }
    }
}


