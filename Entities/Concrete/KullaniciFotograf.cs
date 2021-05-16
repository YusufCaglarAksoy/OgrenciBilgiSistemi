using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class KullaniciFotograf : IEntity
    {
        public int Id { get; set; }
        public string FotografYolu { get; set; }
        public DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }

    }
}
