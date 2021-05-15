using Business.Abstract;
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

        public IResult Add(Akademisyen akademisyen)
        {
            _akademisyenDal.Add(akademisyen);
            return new Result(true, Messages.AkademisyenAdded);
        }

        public IResult Delete(Akademisyen akademisyen)
        {
            _akademisyenDal.Delete(akademisyen);
            return new Result(true, Messages.AkademisyenDeleted);
        }

        public IResult Update(Akademisyen akademisyen)
        {
            _akademisyenDal.Update(akademisyen);
            return new Result(true, Messages.AkademisyenUpdated);
        }

        public IDataResult<List<Akademisyen>> GetAll()
        {
            return new SuccessDataResult<List<Akademisyen>>(_akademisyenDal.GetAll(), Messages.AkademisyenListed);
        }

        public IDataResult<List<Akademisyen>> GetByBolumId(int Id)
        {
            return new SuccessDataResult<List<Akademisyen>>(_akademisyenDal.GetAll(a => a.BolumId == Id), Messages.AkademisyenGeted);
        }

        public IDataResult<Akademisyen> GetBySicilNo(int sicilNo)
        {
            return new SuccessDataResult<Akademisyen>(_akademisyenDal.Get(a => a.SicilNo == sicilNo), Messages.AkademisyenGeted);

        }

        public IDataResult<Akademisyen> GetByEMail(string email)
        {
            return new SuccessDataResult<Akademisyen>(_akademisyenDal.Get(a => a.EMail == email), Messages.AkademisyenGeted);
        }

        public IDataResult<List<Akademisyen>> GetByUnvanId(int Id)
        {
            return new SuccessDataResult<List<Akademisyen>>(_akademisyenDal.GetAll(a => a.UnvanId == Id), Messages.AkademisyenGeted);
        }
    }

}

