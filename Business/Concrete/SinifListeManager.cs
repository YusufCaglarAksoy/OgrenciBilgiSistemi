using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public IDataResult<SinifListe> GetById(string Id)
        {
            return new SuccessDataResult<SinifListe>(_sinifListeDal.Get(s => s.SubeListesiId == Id), Messages.SinifListeGeted);
        }

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
        public IResult Update(SinifListe sinifListe)
        {
            _sinifListeDal.Update(sinifListe);
            return new Result(true, Messages.SinifListeUpdated);
        }
        public IDataResult<List<SinifListe>> GetAll()
        {
            return new SuccessDataResult<List<SinifListe>>(_sinifListeDal.GetAll(), Messages.SinifListeListed);
        }
    }
}