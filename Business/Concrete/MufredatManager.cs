using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IDataResult<Mufredat> GetById(int Id)
        {
            return new SuccessDataResult<Mufredat>(_mufredatDal.Get(m =>m.Id == Id), Messages.MufredatGeted);
        }

        public IDataResult<List<Mufredat>> GetAll()
        {
            return new SuccessDataResult<List<Mufredat>>(_mufredatDal.GetAll(), Messages.MufredatListed);
        }

        public IResult Add(Mufredat mail)
        {
            _mufredatDal.Add(mail);
            return new Result(true, Messages.MufredatAdded);
        }

        public IResult Update(Mufredat mail)
        {
            _mufredatDal.Update(mail);
            return new Result(true, Messages.MufredatUpdated);
        }

        public IResult Delete(Mufredat mail)
        {
            _mufredatDal.Delete(mail);
            return new Result(true, Messages.MufredatDeleted);
        }
    }
}

