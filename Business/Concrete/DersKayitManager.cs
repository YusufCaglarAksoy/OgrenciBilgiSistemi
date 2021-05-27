using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DersKayitManager : IDersKayitService
    {
        IDersKayitDal _derskayitDal;
        public DersKayitManager(IDersKayitDal dersKayitDal)
        {
            _derskayitDal = dersKayitDal;
        }

        public IResult Add(DersKayit dersKayit)
        {
            _derskayitDal.Add(dersKayit);
            return new Result(true);
        }

        public IResult Update(DersKayit dersKayit)
        {
            _derskayitDal.Update(dersKayit);
            return new Result(true);
        }

        public IResult Delete(int Id)
        {
            DersKayit dersKayit = _derskayitDal.Get(d => d.Id == Id);
            _derskayitDal.Delete(dersKayit);
            return new Result(true);
        }

        public IDataResult<List<DersKayitDetayDto>> GetAll()
        {
            return new SuccessDataResult<List<DersKayitDetayDto>>(_derskayitDal.GetDersKayitDetaylari());
        }

        public IDataResult<List<DersKayitDetayDto>> GetByDanismanId(int danismanId)
        {
            return new SuccessDataResult<List<DersKayitDetayDto>>(_derskayitDal.GetDersKayitDetaylari(d => d.DanismanId == danismanId));

        }

        public IDataResult<List<DersKayitDetayDto>> GetById(int Id)
        {
           return new SuccessDataResult<List<DersKayitDetayDto>>(_derskayitDal.GetDersKayitDetaylari(d => d.Id == Id));
        }

        public IDataResult<List<DersKayitDetayDto>> GetByOgrenciId(int ogrenciId)
        {
            return new SuccessDataResult<List<DersKayitDetayDto>>(_derskayitDal.GetDersKayitDetaylari(d => d.OgrenciId == ogrenciId));
        }


    }
}
