using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Fakulte : IEntity
    {
        public int Id { get; set; }
        public string FakulteAdi { get; set; }
    }
}
