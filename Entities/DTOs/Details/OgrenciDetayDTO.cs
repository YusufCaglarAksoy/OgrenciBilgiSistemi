using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OgrenciDetayDto : IDto
    {
        public string Isim { get; set; }
        public string Soyad { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string TelefonNumarasi { get; set; }
        public string UnvanAdi { get; set; }
        public int OgrenciNo { get; set; }
        public string BolumAdi { get; set; }
        public string FakulteAdi { get; set; }

        public string AileAdres { get; set; }
        public string AileTelefon { get; set; }

        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public int SubeKodu { get; set; }
        public string HesapNumarası { get; set; }
        public string IBAN { get; set; }
        public string HesapSahibininAdiSoyadi { get; set; }

        public string DanismanAdi { get; set; }
        public string DanismanSoyadi { get; set; }
        public string DanismanEMail { get; set; }
        public string DanismanTelefonNumarasi { get; set; }
        public string DanismanUnvanAdi { get; set; }

        public int MufredatId { get; set; }
        public int BolumId { get; set; }
        public int DanismanId { get; set; }
        public byte[] SaltSifre { get; set; }
        public byte[] HashSifre { get; set; }
        public int UnvanId { get; set; }
        public int Id { get; set; }
    }
}
