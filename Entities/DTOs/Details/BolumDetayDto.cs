using Core.Entities;

namespace Entities.DTOs
{
    public class BolumDetayDto : IDto
    {
        public int Id { get; set; }
        public string BolumAdi { get; set; }
        public int FakulteId { get; set; }
        public string FakulteAdi { get; set; }
    }

}
