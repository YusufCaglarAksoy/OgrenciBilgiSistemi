using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class MufredatManager : IMufredatService
    {
        IMufredatDal _mufredatDal;
        public MufredatManager(IMufredatDal mufredatDal)
        {
            _mufredatDal = mufredatDal;
        }

        [ValidationAspect(typeof(MufredatValidator))]
        public IResult Add(Mufredat mufredat)
        {
            _mufredatDal.Add(mufredat);
            return new Result(true, Messages.MufredatAdded);
        }

        [ValidationAspect(typeof(MufredatValidator))]
        public IResult Update(Mufredat mufredat)
        {
            _mufredatDal.Update(mufredat);
            return new Result(true, Messages.MufredatUpdated);
        }

        public IResult Delete(int Id)
        {
            Mufredat mufredat = _mufredatDal.Get(m => m.Id == Id);
            _mufredatDal.Delete(mufredat);
            return new Result(true, Messages.MufredatDeleted);
        }
        public IDataResult<List<Mufredat>> GetAll()
        {
            return new SuccessDataResult<List<Mufredat>>(_mufredatDal.GetAll(), Messages.MufredatListed);
        }
        public IDataResult<List<MufredatDetayDto>> GetById(int Id)
        {
            return new SuccessDataResult<List<MufredatDetayDto>>(_mufredatDal.GetMufredatDetaylari(m => m.Id == Id), Messages.MufredatGeted);
        }
        public IDataResult<List<MufredatDetayDto>> GetAllByMufredatDto()
        {
            return new SuccessDataResult<List<MufredatDetayDto>>(_mufredatDal.GetMufredatDetaylari(), Messages.MufredatListed);
        }
    }
}

