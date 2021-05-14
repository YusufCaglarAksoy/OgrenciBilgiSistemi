using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        public IResult Add(Ogrenci ogrenci)
        {
            _ogrenciDal.Add(ogrenci);
            return new Result(true, Messages.OgrenciAdded);
        }

        public IResult Delete(Ogrenci ogrenci)
        {
            _ogrenciDal.Delete(ogrenci);
            return new Result(true, Messages.OgrenciDeleted); 
        }

        public IDataResult<List<Ogrenci>> GetAll()
        {
            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll(), Messages.OgrenciListed); 
        }

        public IDataResult<Ogrenci> GetById(int Id)
        {
            return new SuccessDataResult<Ogrenci>(_ogrenciDal.Get(n => n.KullaniciId == Id), Messages.OgrenciGeted); 
        }

        public IResult Update(Ogrenci ogrenci)
        {
            _ogrenciDal.Update(ogrenci);

            return new Result(true, Messages.OgrenciUpdated); 
        }
    }

}

