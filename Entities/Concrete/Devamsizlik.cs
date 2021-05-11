using Core.Entities;

namespace Entities.Concrete
{
    public class Devamsizlik : IEntity
    {
        public int DevamsizlikId { get; set; }
        public string OgrenciId { get; set; }
        public string DersId { get; set; }
        public string DevamsizlikDurumu { get; set; }
    }
}


