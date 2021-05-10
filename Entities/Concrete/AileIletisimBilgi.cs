using Core.Entities;

namespace Entities.Concrete
{
    public class AileIletisimBilgi : IEntity
    {
        public int AileIletisimBilgiId { get; set; }
        public string OgrenciAileAdres { get; set; }
        public string OgrenciAileIl { get; set; }
        public string OgrenciAileIlce { get; set; }
        public string OgrenciAileTelefon { get; set; }
    }
}


