using Core.Entities;

namespace Entities.Concrete
{
    public class SinifListe : IEntity
    {
        public int Id { get; set; }
        public int SubeId { get; set; }
        public int OgrenciId { get; set; }

    }
}


