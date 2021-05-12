using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IDataResult<List<Harc>> GetAll()
        {
            return new SuccessDataResult<List<Harc>>(_harcDal.GetAll(), Messages.HarcListelendi);
        }

        public IDataResult<Harc> GetById(int Id)
        {
            return new SuccessDataResult<Harc>(_harcDal.Get(h => h.Id == Id), Messages.HarcGeted);
        }

        public IResult Update(Harc harc)
        {
            _harcDal.Update(harc);
            return new Result(true, Messages.HarcUpdated);
        }
    }

}