using Core.Entities;

namespace Entities.DTOs
{
    public class MufredatDetayDto : IDto
    {
        public int Id { get; set; }
        public int MufredatId { get; set; }
        public string DersAdi { get; set; }
        public string DersKodu { get; set; }
        public int DersId { get; set; }
        public string DonemAdi { get; set; }
    }

}
