using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sinav:IEntity
    {
        public int Id { get; set; }
        public string SinavAdi { get; set; }
        public DateTime SinavTarihi { get; set; }
    }
}
