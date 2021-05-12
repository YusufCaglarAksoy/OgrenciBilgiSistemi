using Core.Entities;

namespace Entities.Concrete
{
    public class Sube : IEntity
    {
        public int Id { get; set; }
        public int DersId { get; set; }
        public int OgretmenId { get; set; }
    }
}


