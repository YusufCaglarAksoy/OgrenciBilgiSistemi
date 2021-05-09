using Core.Entities;

namespace Entities.Concrete
{
    public class DigerIletisimBilgileri : IEntity
    {
        public string OgrenciCepTelefonu { get; set; }
        public string EpostaBir { get; set; }
        public string EpostaIki { get; set; }
    }
}


