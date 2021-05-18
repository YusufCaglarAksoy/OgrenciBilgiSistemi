using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class Fotograf  : IEntity
    {
        public int Id { get; set; }
        public string FotografYolu { get; set; }
        public DateTime Tarih { get; set; }
    }
}
