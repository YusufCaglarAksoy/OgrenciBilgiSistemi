using Core.Entities;

namespace Entities.Concrete
{
    public class Mail : IEntity
    {
        public int Id { get; set; }
        public string MailBaslik { get; set; }
        public string MailText { get; set; }
        public string AliciMail { get; set; }
        public string GonderenMail { get; set; }
    }
}


