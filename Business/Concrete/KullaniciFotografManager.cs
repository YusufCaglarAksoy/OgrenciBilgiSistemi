using Business.Abstract;
using Business.Constants;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concrete
{
    public class KullaniciFotografManager : IKullaniciFotografService
    {
        IKullaniciFotografDal _kullaniciFotografDal;
        public KullaniciFotografManager(IKullaniciFotografDal kullaniciFotografDal)
        {
            _kullaniciFotografDal = kullaniciFotografDal;
        }

        public IResult Add(IFormFile file, KullaniciFotograf kullaniciFotograf)
        {

            kullaniciFotograf.FotografYolu = FileHelper.Add(file);
            kullaniciFotograf.Tarih = DateTime.Now;
            _kullaniciFotografDal.Add(kullaniciFotograf);

            return new SuccessResult(Messages.KullaniciFotografAdded);
        }

        public IResult Delete(KullaniciFotograf kullaniciFotograf)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _kullaniciFotografDal.Get(I => I.KullaniciId == kullaniciFotograf.KullaniciId).FotografYolu;
            _kullaniciFotografDal.Delete(kullaniciFotograf);
            return new SuccessResult(Messages.KullaniciFotografDeleted);
        }

        public IResult Update(IFormFile file, KullaniciFotograf kullaniciFotograf)
        {

            kullaniciFotograf.FotografYolu = FileHelper.Update(_kullaniciFotografDal.Get(k => k.KullaniciId == kullaniciFotograf.KullaniciId).FotografYolu, file);
            _kullaniciFotografDal.Update(kullaniciFotograf);
            return new SuccessResult(Messages.KullaniciFotografUpdated);
        }

        public IDataResult<List<KullaniciFotograf>> GetAll()
        {
            return new SuccessDataResult<List<KullaniciFotograf>>(_kullaniciFotografDal.GetAll(), Messages.KullaniciFotografListed);
        }

        public IDataResult<KullaniciFotograf> GetByUserId(string Id)
        {
            return new SuccessDataResult<KullaniciFotograf>(_kullaniciFotografDal.Get(kf => kf.KullaniciId == Id), Messages.KullaniciFotografGeted);
        }

        public IDataResult<KullaniciFotograf> GetById(string Id)
        {
            return new SuccessDataResult<KullaniciFotograf>(_kullaniciFotografDal.Get(kf =>kf.FotografId == Id), Messages.KullaniciFotografGeted);
        }
    }
}
