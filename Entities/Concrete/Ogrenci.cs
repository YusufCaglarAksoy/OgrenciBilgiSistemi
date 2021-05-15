using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Ogrenci :Kullanici
    {
        public int OgrenciNo { get; set; }
        public int MufredatId { get; set; }
        public int BolumId { get; set; }

        public string AileAdres { get; set; }
        public string AileTelefon { get; set; }

        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public int SubeKodu { get; set; }
        public string HesapNumarası { get; set; }
        public string IBAN { get; set; }
        public string HesapSahibininAdiSoyadi { get; set; }

        public int DanismanId { get; set; }


    }
}


