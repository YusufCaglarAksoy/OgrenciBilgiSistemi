using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class DersKayit : IEntity
    {
        public int Id { get; set; }
        public int DersId1 { get; set; }
        public int DersId2 { get; set; }
        public int DersId3 { get; set; }
        public int DersId4 { get; set; }
        public int DersId5 { get; set; }
        public int DersId6 { get; set; }
        public int DersId7 { get; set; }
        public int DersId8 { get; set; }
        public int DersId9 { get; set; }
        public int DersId10 { get; set; }
        public int OgrenciId { get; set; }
        public int DanismanId { get; set; }
        public bool OnayDurumu { get; set; }

    }
}
