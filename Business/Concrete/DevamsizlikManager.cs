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
    public class DevamsizlikManager : IDevamsizlikService
    {
        IDevamsizlikDal _devamsizlikDal;

        public DevamsizlikManager(IDevamsizlikDal devamsizlikDal)
        {
            _devamsizlikDal = devamsizlikDal;
        }

        [ValidationAspect(typeof(DevamsizlikValidator))]
        public IResult Add(Devamsizlik devamsizlik)
        {
            _devamsizlikDal.Add(devamsizlik);
            return new Result(true, Messages.DevamsizlikAdded);
        }

        public IResult Delete(int Id)
        {
            Devamsizlik devamsizlik = _devamsizlikDal.Get(d => d.Id == Id);
            _devamsizlikDal.Add(devamsizlik);
            return new Result(true, Messages.DevamsizlikDeleted);
        }

        [ValidationAspect(typeof(DevamsizlikValidator))]
        public IResult Update(Devamsizlik devamsizlik)
        {
            _devamsizlikDal.Update(devamsizlik);
            return new Result(true, Messages.DevamsizlikUpdated);
        }

        public IDataResult<List<Devamsizlik>> GetAll()
        {
            return new SuccessDataResult<List<Devamsizlik>>(_devamsizlikDal.GetAll(), Messages.DevamsizlikListed);
        }

        public IDataResult<List<DevamsizlikDetayDto>> GetByDersId(int dersId)
        {
            return new SuccessDataResult<List<DevamsizlikDetayDto>>(_devamsizlikDal.GetDevamsizlikDetaylari(a => a.DersId == dersId), Messages.DevamsizlikGeted);
        }

        public IDataResult<List<DevamsizlikDetayDto>> GetByDevamsizlikDurumu(bool devamsizlikDurumu)
        {
            return new SuccessDataResult<List<DevamsizlikDetayDto>>(_devamsizlikDal.GetDevamsizlikDetaylari(a => a.DevamsizlikDurumu == devamsizlikDurumu), Messages.DevamsizlikGeted);
        }

        public IDataResult<List<DevamsizlikDetayDto>> GetById(int Id)
        {
            return new SuccessDataResult<List<DevamsizlikDetayDto>>(_devamsizlikDal.GetDevamsizlikDetaylari(a => a.Id==Id), Messages.DevamsizlikGeted);
        }

        public IDataResult<List<DevamsizlikDetayDto>> GetByOgrenciId(int ogrenciId)
        {
            return new SuccessDataResult<List<DevamsizlikDetayDto>>(_devamsizlikDal.GetDevamsizlikDetaylari(a => a.OgrenciId == ogrenciId), Messages.DevamsizlikGeted);
        }
        public IDataResult<List<DevamsizlikDetayDto>> GetAllByDevamsizlikDto()
        {
            return new SuccessDataResult<List<DevamsizlikDetayDto>>(_devamsizlikDal.GetDevamsizlikDetaylari(), Messages.DevamsizlikListed);
        }
    }
}


