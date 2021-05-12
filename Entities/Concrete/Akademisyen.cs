using Core.Entities;

namespace Entities.Concrete
{
    public class Akademisyen : Kullanici
    {
        public int Id { get; set; }
        public int UnvanId { get; set; }
        public int BolumId { get; set; }
    }
}


