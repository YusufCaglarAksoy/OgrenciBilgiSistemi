using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMufredatDal : EfEntityRepositoryBase<Mufredat, OBSContext>, IMufredatDal
    {

    }
}
