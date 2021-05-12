using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Not:IEntity
    {
        public int Id { get; set; }
        public int SinavId { get; set; }
        public int DersId { get; set; }
        public int OgrenciId { get; set; }
        public int SinavNot { get; set; }
    }
}
