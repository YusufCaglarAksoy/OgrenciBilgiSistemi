using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Unvan : IEntity
    {
        public string UnvanId { get; set; }
        public string UnvanAdi { get; set; }
    }
}
