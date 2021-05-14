using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class NotManager : INotService
    {
        INotDal _notDal;

        public NotManager(INotDal notDal)
        {
            _notDal = notDal;
        }

        public IResult Add(Not not)
        {
            _notDal.Add(not);
            return new Result(true, Messages.NotAdded); 
        }

        public IResult Delete(Not not)
        {
            _notDal.Delete(not);
            return new Result(true, Messages.NotDeleted);
        }

        public IDataResult<List<Not>> GetAll()
        {
            return new SuccessDataResult<List<Not>>(_notDal.GetAll(), Messages.notListed);
        }

        public IDataResult<Not> GetById(int Id)
        {
            return new SuccessDataResult<Not>(_notDal.Get(n => n.Id == Id), Messages.NotGeted);
        }

        public IResult Update(Not not)
        {
            _notDal.Update(not);

            return new Result(true, Messages.NotUpdated);
        }
    }
}