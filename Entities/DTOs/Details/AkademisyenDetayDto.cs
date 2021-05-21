using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class AkademisyenDetayDto : IDto
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyad { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string TelefonNumarasi { get; set; }
        public string UnvanAdi { get; set; }
        public int UnvanId { get; set; }
        public string FakulteAdi { get; set; }
        public string BolumAdi { get; set; }
        public int BolumId { get; set; }
        public int SicilNo { get; set; }
        public byte[] SaltSifre { get; set; }
        public byte[] HashSifre { get; set; }
    }

}
