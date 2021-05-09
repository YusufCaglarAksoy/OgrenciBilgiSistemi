using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSinavDal : EfEntityRepositoryBase<Sinav, OBSContext>, ISinavDal
    {

    }
}
