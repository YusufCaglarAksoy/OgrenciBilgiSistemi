using Core.Entities;

namespace Entities.Concrete
{
    public class IkametgahBilgi : IEntity
    {
        public int IkametgahBilgiId { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public int PostaKodu { get; set; }
        public int TelefonNo { get; set; }

    }
}


