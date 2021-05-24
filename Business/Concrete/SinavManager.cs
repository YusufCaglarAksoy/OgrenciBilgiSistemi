using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SinavManager : ISinavService
    {
        ISinavDal _sinavDal;
        ISubeDal _subeDal;

        public SinavManager(ISinavDal sinavDal, ISubeDal subeDal)
        {
            _sinavDal = sinavDal;
            _subeDal = subeDal;

        }

        [ValidationAspect(typeof(SinavValidator))]
        public IResult Add(Sinav sinav)
        {
            _sinavDal.Add(sinav);
            return new Result(true, Messages.SinavAdded);
        }

        public IResult Delete(int Id)
        {
            Sinav sinav = _sinavDal.Get(s => s.Id==Id);
            _sinavDal.Delete(sinav);
            return new Result(true, Messages.SinavDeleted);
        }

        [ValidationAspect(typeof(SinavValidator))]
        public IResult Update(Sinav sinav)
        {
            _sinavDal.Update(sinav);
            return new Result(true, Messages.SinavUpdated);
        }

        public IDataResult<List<Sinav>> GetAll()
        {
            return new SuccessDataResult<List<Sinav>>(_sinavDal.GetAll(), Messages.SinavListed);
        }
        public IDataResult<List<SinavDetayDto>> GetById(int Id)
        {

            return new SuccessDataResult<List<SinavDetayDto>>(_sinavDal.GetSinavDetaylari(s => s.Id == Id), Messages.SinavGeted);
        }

        public IDataResult<List<SinavDetayDto>> GetAllBySinavDto()
        {
            return new SuccessDataResult<List<SinavDetayDto>>(_sinavDal.GetSinavDetaylari(), Messages.SinavListed);
        }

        public IDataResult<List<SinavDetayDto>> GetByAkademisyenId(int Id)
        {
            return new SuccessDataResult<List<SinavDetayDto>>(_sinavDal.GetSinavDetaylari(s => s.AkademisyenId==Id), Messages.SinavGeted);
        }

    }
}
