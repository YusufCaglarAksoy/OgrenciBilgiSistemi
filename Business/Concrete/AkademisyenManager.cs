﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AkademisyenManager : IKullaniciService, IAkademisyenService
    {
        IAkademisyenDal _akademisyenDal;

        public AkademisyenManager(IAkademisyenDal akademisyenDal)
        {
            _akademisyenDal = akademisyenDal;
        }

        public IDataResult<Akademisyen> GetById(string Id)
        {

            return new SuccessDataResult<Akademisyen>(_akademisyenDal.Get(a=>a.AkademisyenId == Id), Messages.AkademisyenGeted);
        }

        public IResult Add(Akademisyen akademisyen)
        {
            _akademisyenDal.Add(akademisyen);
            return new Result(true, Messages.AkademisyenAdedd);
        }

        public IResult Delete(Akademisyen akademisyen)
        {
            _akademisyenDal.Delete(akademisyen);
            return new Result(true, Messages.AkademisyenDeleted);
        }

        public IResult Update(Akademisyen akademisyen)
        {
            _akademisyenDal.Update(akademisyen);
            return new Result(true, Messages.);
        }

        public IDataResult<List<Akademisyen>> GetAll()
        {
            return new SuccessDataResult<List<Akademisyen>>(_akademisyenDal.GetAll(), Messages.);
        }
    }

}
