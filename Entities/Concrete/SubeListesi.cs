using Core.Entities;

namespace Entities.Concrete
{
    public class SubeListe : IEntity
    {
        public string SubeListesiId { get; set; }
        public string SubeId { get; set; }
        public int OgrenciId { get; set; }

    }
}


