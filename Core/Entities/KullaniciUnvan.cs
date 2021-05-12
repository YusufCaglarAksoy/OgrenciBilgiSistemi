using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class KullaniciUnvan :IEntity
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public int UnvanId { get; set; }
    }
}
