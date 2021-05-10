using Core.Entities;

namespace Entities.Concrete
{
    public class BankaBilgi : IEntity
    {
        public int BankaBilgiId { get; set; }
        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public int SubeKodu { get; set; }
        public long HesapNumarası { get; set; }
        public long IBAN { get; set; }
        public string HesapSahibininAdiSoyadi { get; set; }
    }
}


