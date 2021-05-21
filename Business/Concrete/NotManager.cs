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
    public class NotManager : INotService
    {
        INotDal _notDal;

        public NotManager(INotDal notDal)
        {
            _notDal = notDal;
        }

        [ValidationAspect(typeof(NotValidator))]
        public IResult Add(Not not)
        {
            _notDal.Add(not);
            return new Result(true, Messages.NotAdded); 
        }

        public IResult Delete(int Id)
        {
            Not not = _notDal.Get(n => n.Id == Id);
            _notDal.Delete(not);
            return new Result(true, Messages.NotDeleted);
        }

        [ValidationAspect(typeof(NotValidator))]
        public IResult Update(Not not)
        {
            _notDal.Update(not);
            return new Result(true, Messages.NotUpdated);
        }
        public IDataResult<List<Not>> GetAll()
        {
            return new SuccessDataResult<List<Not>>(_notDal.GetAll(), Messages.NotListed);
        }

        public IDataResult<List<NotDetayDto>> GetByOgrenciId(int ogrenciId)
        {
            return new SuccessDataResult<List<NotDetayDto>>(_notDal.GetNotDetaylari(n => n.OgrenciId == ogrenciId), Messages.NotGeted);
        }

        public IDataResult<List<NotDetayDto>> GetBySinavId(int sinavId)
        {
            return new SuccessDataResult<List<NotDetayDto>>(_notDal.GetNotDetaylari(n => n.SinavId == sinavId), Messages.NotGeted);
        }

        public IDataResult<List<NotDetayDto>> GetById(int Id)
        {
            return new SuccessDataResult<List<NotDetayDto>>(_notDal.GetNotDetaylari(n => n.Id == Id), Messages.NotGeted);
        }

        public IDataResult<List<NotDetayDto>> GetAllByNotDto()
        {
            return new SuccessDataResult<List<NotDetayDto>>(_notDal.GetNotDetaylari(), Messages.NotListed);
        }
    }
}