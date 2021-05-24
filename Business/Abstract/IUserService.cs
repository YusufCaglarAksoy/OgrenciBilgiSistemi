using Core.Entities;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<Unvan>> GetClaims(Kullanici kullanici);
        IDataResult<AccessToken> CreateAccessToken(Kullanici kullanici);
    }
}