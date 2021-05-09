using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Not:IEntity
    {
        public string NotId { get; set; }
        public string SinavId { get; set; }
        public string DersId { get; set; }
        public string OgrenciId { get; set; }
        public int SinavNot { get; set; }
    }
}
