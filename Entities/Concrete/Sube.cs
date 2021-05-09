using Core.Entities;

namespace Entities.Concrete
{
    public class Sube : IEntity
    {
        public string SubeId { get; set; }
        public string DersId { get; set; }
        public int OgretmenId { get; set; }
    }
}


