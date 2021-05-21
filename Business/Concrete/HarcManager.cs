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

        public IResult Delete(int Id)
        {
            Harc harc = _harcDal.Get(h => h.Id == Id);
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

        public IDataResult<List<HarcDetayDto>> GetById(int Id)
        {
            return new SuccessDataResult<List<HarcDetayDto>>(_harcDal.GetHarcDetaylari(h => h.Id == Id), Messages.HarcGeted);
        }

        public IDataResult<List<HarcDetayDto>> GetByOgrenciId(int Id)
        {
            return new SuccessDataResult<List<HarcDetayDto>>(_harcDal.GetHarcDetaylari(h => h.OgrenciId == Id), Messages.HarcGeted);
        }

        public IDataResult<List<HarcDetayDto>> GetAllByHarcDto()
        {
            return new SuccessDataResult<List<HarcDetayDto>>(_harcDal.GetHarcDetaylari(), Messages.HarcListed);
        }
    }

}