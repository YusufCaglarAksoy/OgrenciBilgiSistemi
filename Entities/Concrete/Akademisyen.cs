using Core.Entities;

namespace Entities.Concrete
{
    public class Akademisyen : Kullanici
    {
        public string AkademisyenId { get; set; }
        public string UnvanId { get; set; }
        public int BolumId { get; set; }
        public int KullaniciId { get; set; }
    }
}


