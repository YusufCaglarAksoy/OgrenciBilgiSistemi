using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class DevamsizlikManager : IDevamsizlikService
    {
        IDevamsizlikDal _devamsizlikDal;

        public DevamsizlikManager(IDevamsizlikDal devamsizlikDal)
        {
            _devamsizlikDal = devamsizlikDal;
        }

        public IResult Add(Devamsizlik devamsizlik)
        {
            _devamsizlikDal.Add(devamsizlik);
            return new Result(true, Messages.DevamsizlikAdded);
        }

        public IResult Delete(Devamsizlik devamsizlik)
        {
            _devamsizlikDal.Add(devamsizlik);
            return new Result(true, Messages.DevamsizlikDeleted);
        }

        public IDataResult<List<Devamsizlik>> GetAll()
        {
            return new SuccessDataResult<List<Devamsizlik>>(_devamsizlikDal.GetAll(), Messages.DevamsizlikListed);
        }

        public IDataResult<List<Devamsizlik>> GetByDersId(int dersId)
        {
            return new SuccessDataResult<List<Devamsizlik>>(_devamsizlikDal.GetAll(a => a.DersId == dersId), Messages.DevamsizlikGeted);
        }

        public IDataResult<List<Devamsizlik>> GetByDevamsizlikDurumu(bool devamsizlikDurumu)
        {
            return new SuccessDataResult<List<Devamsizlik>>(_devamsizlikDal.GetAll(a => a.DevamsizlikDurumu == devamsizlikDurumu), Messages.DevamsizlikGeted);
        }

        public IDataResult<Devamsizlik> GetById(int Id)
        {
            return new SuccessDataResult<Devamsizlik>(_devamsizlikDal.Get(a => a.Id == Id), Messages.DevamsizlikGeted);
        }

        public IDataResult<List<Devamsizlik>> GetByOgrenciId(int ogrenciId)
        {
            return new SuccessDataResult<List<Devamsizlik>>(_devamsizlikDal.GetAll(a => a.OgrenciId == ogrenciId), Messages.DevamsizlikGeted);
        }

        public IResult Update(Devamsizlik devamsizlik)
        {
            _devamsizlikDal.Update(devamsizlik);
            return new Result(true, Messages.DevamsizlikUpdated);
        }
    }
}


