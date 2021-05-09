using Core.Entities;

namespace Entities.Concrete
{
    public class ParaIadeBankaBilgileri : IEntity
    {
        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public int SubeKodu { get; set; }
        public int HesapNumarası { get; set; }
        public int IBAN { get; set; }
        public string HesapSahibininAdiSoyadi { get; set; }
    }
}


