using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfNotDal : EfEntityRepositoryBase<Not, OBSContext>, INotDal
    {

    }
}
