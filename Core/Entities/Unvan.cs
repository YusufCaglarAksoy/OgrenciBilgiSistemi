using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Unvan : IEntity
    {
        public int Id { get; set; }
        public string UnvanAdi { get; set; }
    }
}
