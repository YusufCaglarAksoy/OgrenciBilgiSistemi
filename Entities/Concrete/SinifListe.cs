using Core.Entities;

namespace Entities.Concrete
{
    public class SinifListe : IEntity
    {
        public string SubeListesiId { get; set; }
        public string SubeId { get; set; }
        public string OgrenciId { get; set; }

    }
}


