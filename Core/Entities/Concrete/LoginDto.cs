using Core.Entities;

namespace Entities.DTOs
{
    public class LoginDto : IDto
    {

        public int LoginNo { get; set; }
        public string Password { get; set; }
    }
}
