using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class SinavDetayDto : IDto
    {
        public int Id { get; set; }
        public int SinavTurId { get; set; }
        public string SinavAdi{ get; set; }
        public DateTime SinavTarihi { get; set; }
        public string DersAdi { get; set; }
        public int DersId { get; set; }
        public string DersKodu { get; set; }
        public int AkademisyenId { get; set; }
    }

}
