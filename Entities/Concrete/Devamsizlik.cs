using Core.Entities;

namespace Entities.Concrete
{
    public class Devamsizlik : IEntity
    {
        public int OgrenciId { get; set; }
        public string DevamsizlikId { get; set; }
        public string DersId { get; set; }
        public string DevamsizlikDurumu { get; set; }
    }
}


