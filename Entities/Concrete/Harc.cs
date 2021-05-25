using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Harc: IEntity
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public int Donem { get; set; }
        public string Tipi { get; set; }
        public string Turu { get; set; }
        public DateTime TahakkukTarihi { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public Decimal Tutar { get; set; }
        
    }
}
