using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class KullaniciFotograf : IEntity
    {
        public string FotografId { get; set; }
        public string FotografYolu { get; set; }
        public string KullaniciId { get; set; }
        public DateTime Tarih { get; set; }

    }
}
