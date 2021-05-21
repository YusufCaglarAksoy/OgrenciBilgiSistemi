using Core.Entities;

namespace Entities.DTOs
{
    public class SinifListeDetayDto : IDto
    {
        public int Id { get; set; }
        public int SubeId { get; set; }
        public int OgrenciId { get; set; }
        public string OgretmenAdi { get; set; }
        public string OgretmenSoyadi { get; set; }
        public string OgretmenMail { get; set; }
        public string DersAdi { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string OgrenciMail { get; set; }
        public int OgrenciNo { get; set; }
    }

}
