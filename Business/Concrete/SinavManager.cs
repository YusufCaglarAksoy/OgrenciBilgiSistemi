using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SinavManager : ISinavService
    {
        ISinavDal _sinavDal;

        public SinavManager(ISinavDal sinavDal)
        {
            _sinavDal = sinavDal;
        }

        public IDataResult<Sinav> GetById(int Id)
        {

            return new SuccessDataResult<Sinav>(_sinavDal.Get(s => s.Id == Id), Messages.SinavGeted);
        }

        public IResult Add(Sinav sinav)
        {
            _sinavDal.Add(sinav);
            return new Result(true, Messages.SinavAdded);
        }

        public IResult Delete(Sinav sinav)
        {
            _sinavDal.Delete(sinav);
            return new Result(true, Messages.SinavDeleted);
        }

        public IResult Update(Sinav sinav)
        {
            _sinavDal.Update(sinav);
            return new Result(true, Messages.SinavUpdated);
        }

        public IDataResult<List<Sinav>> GetAll()
        {
            return new SuccessDataResult<List<Sinav>>(_sinavDal.GetAll(), Messages.SinavListed);
        }
    }
}
