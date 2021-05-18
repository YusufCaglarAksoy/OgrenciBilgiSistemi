using Core.Entities;

namespace Entities.DTOs
{
    public class MufredatDetayDto : IDto
    {
        public int MufredatId { get; set; }
        public string DersAdi { get; set; }
        public string DersKodu { get; set; }
        public string DonemAdi { get; set; }
    }

}
