using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AkademisyenForRegisterDto :RegisterDto
    {
        public int BolumId { get; set; }
        public int SicilNo { get; set; }
    }
}
