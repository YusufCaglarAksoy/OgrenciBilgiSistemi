using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class SinavDetayDto : IDto
    {
        public string SinavAdi{ get; set; }
        public DateTime SinavTarihi { get; set; }
        public string DersAdi { get; set; }
    }

}
