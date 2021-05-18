using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SubeDetayDto : IDto
    {
        public string DersAdi { get; set; }
        public string DersKodu { get; set; }
        public string OgretmenAdi { get; set; }
        public string OgretmenSoyadi { get; set; }
        public string OgretmenMail { get; set; }
    }
}
