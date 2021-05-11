using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Fakulte : IEntity
    {
        public int FakulteId { get; set; }
        public string FakulteAdi { get; set; }
    }
}
