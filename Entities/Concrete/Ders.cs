using Core.Entities;

namespace Entities.Concrete
{
    public class Ders:IEntity
    {
        public string DersId { get; set; }
        public string DerdAdi { get; set; }
        public int Sube { get; set; }
    }
}
