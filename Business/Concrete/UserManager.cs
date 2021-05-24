using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        private ITokenHelper _tokenHelper;
        public UserManager(IUserDal userDal, ITokenHelper tokenHelper)
        {
            _userDal = userDal;
            _tokenHelper = tokenHelper;
        }
        public IDataResult<List<Unvan>> GetClaims(Kullanici kullanici)
        {
            return new SuccessDataResult<List<Unvan>>(_userDal.GetClaims(kullanici));
        }
        public IDataResult<AccessToken> CreateAccessToken(Kullanici kullanici)
        {
            var claims = GetClaims(kullanici).Data;
            var accessToken = _tokenHelper.CreateToken(kullanici, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Token oluşturuldu");
        }
    }
}
