using Core.Entities;

namespace Entities.Concrete
{
    public class Akademisyen : Kullanici
    {
        public int Id { get; set; }
        public int BolumId { get; set; }
        public int SicilNo { get; set; }
    }
}


