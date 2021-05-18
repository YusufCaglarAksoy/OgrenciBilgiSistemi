using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class IdareciForRegisterDto : RegisterDto
    {
        public int FakulteId { get; set; }
        public int SicilNo { get; set; }
    }
}
