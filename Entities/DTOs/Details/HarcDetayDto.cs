using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class HarcDetayDto : IDto
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string OgrenciMail { get; set; }
        public int OgrenciNo { get; set; }
        public int Donem { get; set; }
        public string Tipi { get; set; }
        public string Turu { get; set; }
        public DateTime TahakkukTarihi { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public Decimal Tutar { get; set; }
    }
}
