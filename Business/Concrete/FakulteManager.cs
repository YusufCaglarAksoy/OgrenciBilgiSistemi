using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FakulteManager : IFakulteService
    {
        IFakulteDal _fakulteDal;

        public FakulteManager(IFakulteDal fakulteDal)
        {
            _fakulteDal = fakulteDal;
        }

        [ValidationAspect(typeof(FakulteValidator))]
        public IResult Add(Fakulte fakulte)
        {
            _fakulteDal.Add(fakulte);
            return new Result(true, Messages.FakulteAdded);
        }

        public IResult Delete(Fakulte fakulte)
        {
            _fakulteDal.Delete(fakulte);
            return new Result(true, Messages.FakulteDeleted);
        }

        [ValidationAspect(typeof(FakulteValidator))]
        public IResult Update(Fakulte fakulte)
        {
            _fakulteDal.Update(fakulte);
            return new Result(true, Messages.FakulteUpdated);
        }

        public IDataResult<List<Fakulte>> GetAll()
        {
            return new SuccessDataResult<List<Fakulte>>(_fakulteDal.GetAll(), Messages.FakulteListed);
        }

        public IDataResult<Fakulte> GetById(int Id)
        {
            return new SuccessDataResult<Fakulte>(_fakulteDal.Get(f => f.Id == Id), Messages.FakulteGeted);
        }

    }
}