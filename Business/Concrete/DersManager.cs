using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IResult Add(Ders ders)
        {
            _dersDal.Add(ders);
            return new Result(true, Messages.DersAdded);
        }

        public IResult Delete(Ders ders)
        {
            _dersDal.Delete(ders);
            return new Result(true, Messages.DersDeleted);
        }

        public IDataResult<List<Ders>> GetAll()
        {
            return new SuccessDataResult<List<Ders>>(_dersDal.GetAll(), Messages.DersListed);
        }

        public IDataResult<Ders> GetById(int Id)
        {
            return new SuccessDataResult<Ders>(_dersDal.Get(d => d.Id == Id), Messages.DersGeted);
        }

        public IResult Update(Ders ders)
        {
            _dersDal.Update(ders);
            return new Result(true, Messages.DersUpdated);
        }

    }
}