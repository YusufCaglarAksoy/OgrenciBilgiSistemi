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
    public class HarcManager : IHarcService
    {
        IHarcDal _harcDal;

        public HarcManager(IHarcDal harcDal)
        {
            _harcDal = harcDal;
        }

        [ValidationAspect(typeof(HarcValidator))]
        public IResult Add(Harc harc)
        {
            _harcDal.Add(harc);
            return new Result(true, Messages.HarcAdded);
        }

        public IResult Delete(Harc harc)
        {
            _harcDal.Add(harc);
            return new Result(true, Messages.HarcDeleted);
        }

        [ValidationAspect(typeof(HarcValidator))]
        public IResult Update(Harc harc)
        {
            _harcDal.Update(harc);
            return new Result(true, Messages.HarcUpdated);
        }

        public IDataResult<List<Harc>> GetAll()
        {
            return new SuccessDataResult<List<Harc>>(_harcDal.GetAll(), Messages.HarcListed);
        }

        public IDataResult<Harc> GetById(int Id)
        {
            return new SuccessDataResult<Harc>(_harcDal.Get(h => h.Id == Id), Messages.HarcGeted);
        }

        public IDataResult<Harc> GetByOgrenciId(int Id)
        {
            return new SuccessDataResult<Harc>(_harcDal.Get(h => h.OgrenciId == Id), Messages.HarcGeted);
        }

        public IDataResult<List<HarcDetayDto>> GetAllByHarcDto()
        {
            return new SuccessDataResult<List<HarcDetayDto>>(_harcDal.GetHarcDetaylari(), Messages.HarcListed);
        }
    }

}