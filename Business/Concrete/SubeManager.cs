using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SubeManager : ISubeService
    {
        ISubeDal _subeDal;

        public SubeManager(ISubeDal subeDal)
        {
            _subeDal = subeDal;
        }

        public IResult Add(Sube sube)
        {
            _subeDal.Add(sube);
            return new Result(true, Messages.SubeAdded);
        }

        public IResult Delete(Sube sube)
        {
            _subeDal.Delete(sube);
            return new Result(true, Messages.SubeDeleted);
        }

        public IDataResult<List<Sube>> GetAll()
        {
            return new SuccessDataResult<List<Sube>>(_subeDal.GetAll(), Messages.SubeListed);
        }

        public IDataResult<Sube> GetById(int Id)
        {
            return new SuccessDataResult<Sube>(_subeDal.Get(s => s.Id == Id), Messages.SubeGeted);
        }

        public IResult Update(Sube sube)
        {
            _subeDal.Update(sube);
            return new Result(true, Messages.SubeUpdated);
        }
        public IDataResult<List<Sube>> GetByDersId(int dersid)
        {
            return new SuccessDataResult<List<Sube>>(_subeDal.GetAll(d => d.DersId == dersid), Messages.SubeListed);
        }
        public IDataResult<List<Sube>> GetByOgretmenId(int ogretmenid)
        {
            return new SuccessDataResult<List<Sube>>(_subeDal.GetAll(m => m.OgretmenId == ogretmenid), Messages.SubeListed);
        }
    }
}