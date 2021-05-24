using Core.DataAccess;
using Core.Entities;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<Kullanici>
    {
        List<Unvan> GetClaims(Kullanici kullanici);
    }
}
