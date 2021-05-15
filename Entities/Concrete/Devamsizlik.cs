using Core.Entities;

namespace Entities.Concrete
{
    public class Devamsizlik : IEntity
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public bool DevamsizlikDurumu { get; set; }
    }
}


