using Core.Entities;

namespace Entities.Concrete
{
    public class Ogrenci : Kullanici
    {
        public int Id { get; set; }
        public int MufredatId { get; set; }
        public int BolumId { get; set; }

        public string AileAdres { get; set; }
        public string AileTelefon { get; set; }

        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public int SubeKodu { get; set; }
        public long HesapNumarası { get; set; }
        public long IBAN { get; set; }
        public string HesapSahibininAdiSoyadi { get; set; }

        public int AkademisyenId { get; set; }


    }
}


