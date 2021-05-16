using Core.Entities;

namespace Entities.Concrete
{
    public class Ders:IEntity
    {
        public int Id { get; set; }
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public int DonemId { get; set; }
        public int Sinif { get; set; }
        public int BolumId { get; set; }
    }
}
