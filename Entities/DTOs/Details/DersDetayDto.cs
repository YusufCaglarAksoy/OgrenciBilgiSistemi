using Core.Entities;

namespace Entities.DTOs
{
    public class DersDetayDto : IDto
    {
        public int Id { get; set; }
        public string DonemAdi { get; set; }
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public int Sinif { get; set; }
        public string BolumAdi { get; set; }
        public string FakulteAdi { get; set; }
        public int DonemId { get; set; }
        public int BolumId { get; set; }
    }

}
