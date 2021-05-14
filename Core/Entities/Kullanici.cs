using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Kullanici:IEntity
    {
        public int KullaniciId { get; set; }
        public string Isim { get; set; }
        public string Soyad { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string TelefonNumarasi { get; set; }

        public byte[] SaltsSifre { get; set; }
        public byte[] HashsSifre { get; set; }
        public int UnvanId { get; set; }

    }
}


