using Core.Entities;

namespace Entities.DTOs
{
    public class DevamsizlikDetayDto : IDto
    {
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string OgrenciMail { get; set; }
        public int OgrenciNo { get; set; }
        public string DersAdı { get; set; }
        public string DersKodu { get; set; }
        public int Sinif { get; set; }
        public bool DevamsizlikDurumu { get; set; }
    }

}
