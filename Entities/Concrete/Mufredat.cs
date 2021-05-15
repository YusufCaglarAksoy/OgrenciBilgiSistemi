using Core.Entities;

namespace Entities.Concrete
{
    public class Mufredat : IEntity
    {
        public int Id { get; set; }
        public int MufredatId { get; set; }
        public int DersId { get; set; }
    }
}


