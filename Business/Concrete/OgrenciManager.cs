using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IDataResult<Ogrenci> GetByOgrenciNo(int ogrenciNo)
        {
            return new SuccessDataResult<Ogrenci>(_ogrenciDal.Get(n => n.OgrenciNo == ogrenciNo), Messages.OgrenciGeted); 
        }

        public IDataResult<List<Ogrenci>> GetByBolumId(int Id)
        {
            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll(n => n.BolumId == Id), Messages.OgrenciGeted);
        }

        public IDataResult<List<Ogrenci>> GetByDanismanId(int Id)
        {
            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll(n => n.DanismanId == Id), Messages.OgrenciGeted);
        }

        public IDataResult<Ogrenci> GetByEMail(string email)
        {
            return new SuccessDataResult<Ogrenci>(_ogrenciDal.Get(n => n.EMail == email), Messages.OgrenciGeted);
        }

        public IResult Update(Ogrenci ogrenci)
        {
            _ogrenciDal.Update(ogrenci);

            return new Result(true, Messages.OgrenciUpdated); 
        }

        public IDataResult<List<OgrenciDetayDTO>> GetAllByOgrenciDto()
        {
            return new SuccessDataResult<List<OgrenciDetayDTO>>(_ogrenciDal.GetOgrenciDetaylari(), Messages.OgrenciListed);
        }
    }

}

