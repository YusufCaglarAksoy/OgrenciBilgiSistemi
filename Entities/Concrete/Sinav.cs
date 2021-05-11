using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sinav:IEntity
    {
        public string SinavId { get; set; }
        public string SinavAdi { get; set; }
        public DateTime SınavTarihi { get; set; }
    }
}
