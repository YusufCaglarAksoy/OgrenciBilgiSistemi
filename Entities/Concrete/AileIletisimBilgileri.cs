using Core.Entities;

namespace Entities.Concrete
{
    public class AileIletisimBilgileri : IEntity
    {
        public string OgrenciAileAdres { get; set; }
        public string OgrenciAileIl { get; set; }
        public string OgrenciAileIlce { get; set; }
        public string OgrenciAileTelefon { get; set; }
    }
}


