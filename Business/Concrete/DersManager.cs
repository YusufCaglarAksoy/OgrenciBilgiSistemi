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
    public class DersManager : IDersService
    {
        IDersDal _dersDal;

        public DersManager(IDersDal dersDal)
        {
            _dersDal = dersDal;
        }

        [ValidationAspect(typeof(DersValidator))]
        public IResult Add(Ders ders)
        {
            _dersDal.Add(ders);
            return new Result(true, Messages.DersAdded);
        }

        public IResult Delete(int Id)
        {
            Ders ders = _dersDal.Get(d => d.Id == Id);
            _dersDal.Delete(ders);
            return new Result(true, Messages.DersDeleted);
        }

        [ValidationAspect(typeof(DersValidator))]
        public IResult Update(Ders ders)
        {
            _dersDal.Update(ders);
            return new Result(true, Messages.DersUpdated);
        }

        public IDataResult<List<Ders>> GetAll()
        {
            return new SuccessDataResult<List<Ders>>(_dersDal.GetAll(), Messages.DersListed);
        }

        public IDataResult<List<DersDetayDto>> GetById(int Id)
        {
            return new SuccessDataResult<List<DersDetayDto>>(_dersDal.GetDersDetaylari(d => d.Id == Id), Messages.DersGeted);
        }

        public IDataResult<List<DersDetayDto>> GetByDersKodu(string Id)
        {
            return new SuccessDataResult<List<DersDetayDto>>(_dersDal.GetDersDetaylari(d => d.DersKodu == Id), Messages.DersGeted);
        }

        public IDataResult<List<DersDetayDto>> GetAllByDersDto()
        {
            return new SuccessDataResult<List<DersDetayDto>>(_dersDal.GetDersDetaylari(), Messages.DersListed);
        }

        public IDataResult<List<DersDetayDto>> GetByDonemId(int Id)
        {
            return new SuccessDataResult<List<DersDetayDto>>(_dersDal.GetDersDetaylari(d => d.DonemId == Id), Messages.DersGeted);
        }
    }
}