using Core.Entities;

namespace Entities.Concrete
{
    public class Ders:IEntity
    {
        public int Id { get; set; }
        public string DersId { get; set; }
        public string DersAdi { get; set; }
    }
}
