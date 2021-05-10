using Core.Entities;

namespace Entities.Concrete
{
    public class DigerIletisimBilgi : IEntity
    {
        public int DigerIletisimBilgiId { get; set; }
        public string OgrenciCepTelefonu { get; set; }
        public string EpostaBir { get; set; }
        public string EpostaIki { get; set; }
    }
}


