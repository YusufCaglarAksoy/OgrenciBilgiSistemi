using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BolumManager : IBolumService
    {
        IBolumDal _bolumDal;

        public BolumManager(IBolumDal bolumdal)
        {
            _bolumDal = bolumdal;
        }

        [ValidationAspect(typeof(BolumValidator))]
        public IResult Add(Bolum bolum)
        {
            _bolumDal.Add(bolum);
            return new Result(true, Messages.BolumAdded);
        }

        public IResult Delete(Bolum bolum)
        {
            _bolumDal.Delete(bolum);
            return new Result(true, Messages.BolumDeleted);
        }

        [ValidationAspect(typeof(BolumValidator))]
        public IResult Update(Bolum bolum)
        {
            _bolumDal.Update(bolum);
            return new Result(true, Messages.BolumUpdated);
        }

        public IDataResult<List<Bolum>> GetAll()
        {
            return new SuccessDataResult<List<Bolum>>(_bolumDal.GetAll(), Messages.BolumListed);
        }

        public IDataResult<Bolum> GetById(int Id)
        {
            return new SuccessDataResult<Bolum>(_bolumDal.Get(b => b.Id == Id), Messages.BolumGeted);
        }
        public IDataResult<List<Bolum>> GetByFakulteId(int Id)
        {
            return new SuccessDataResult<List<Bolum>>(_bolumDal.GetAll(b => b.FakulteId == Id), Messages.BolumGeted);
        }

        public IDataResult<List<BolumDetayDto>> GetAllByBolumDto()
        {
            return new SuccessDataResult<List<BolumDetayDto>>(_bolumDal.GetBolumDetaylari(), Messages.BolumListed);
        }

    }
}
