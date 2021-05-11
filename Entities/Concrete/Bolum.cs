using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bolum :IEntity
    {
        public int BolumId { get; set; }
        public string BolumAdi { get; set; }
        public int FakulteId { get; set; }
    }
}
