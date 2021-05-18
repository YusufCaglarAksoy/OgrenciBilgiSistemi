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
    public class SinifListeManager : ISinifListeService

    {
        ISinifListeDal _sinifListeDal;

        public SinifListeManager(ISinifListeDal sinifListeDal)
        {
            _sinifListeDal = sinifListeDal;
        }

        [ValidationAspect(typeof(SinifListeValidator))]
        public IResult Add(SinifListe sinifListe)
        {
            _sinifListeDal.Add(sinifListe);
            return new Result(true, Messages.SinifListeAdded);
        }
        public IResult Delete(SinifListe sinifListe)
        {
            _sinifListeDal.Delete(sinifListe);
            return new Result(true, Messages.SinifListeDeleted);
        }
        [ValidationAspect(typeof(SinifListeValidator))]
        public IResult Update(SinifListe sinifListe)
        {
            _sinifListeDal.Update(sinifListe);
            return new Result(true, Messages.SinifListeUpdated);
        }
        public IDataResult<List<SinifListe>> GetAll()
        {
            return new SuccessDataResult<List<SinifListe>>(_sinifListeDal.GetAll(), Messages.SinifListeListed);
        }

        public IDataResult<List<SinifListe>> GetBySubeId(int Id)
        {
            return new SuccessDataResult<List<SinifListe>>(_sinifListeDal.GetAll(s => s.SubeId == Id), Messages.SinifListeGeted);
        }

        public IDataResult<List<SinifListe>> GetByOgrenciId(int Id)
        {
            return new SuccessDataResult<List<SinifListe>>(_sinifListeDal.GetAll(a => a.OgrenciId == Id), Messages.SinifListeGeted);
        }
        public IDataResult<SinifListe> GetById(int Id)
        {
            return new SuccessDataResult<SinifListe>(_sinifListeDal.Get(s => s.Id == Id), Messages.SinifListeGeted);
        }
        public IDataResult<List<SinifListeDetayDto>> GetAllBySinifListeDto()
        {
            return new SuccessDataResult<List<SinifListeDetayDto>>(_sinifListeDal.GetSinifListeDetaylari(), Messages.SinifListeListed);
        }
    }
}