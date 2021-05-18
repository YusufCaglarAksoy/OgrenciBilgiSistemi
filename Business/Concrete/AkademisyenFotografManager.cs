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
    public class AkademisyenFotografManager : IAkademisyenFotografService
    {
        IAkademisyenFotografDal _akademisyenFotografDal;
        public AkademisyenFotografManager(IAkademisyenFotografDal akademisyenFotografDal)
        {
            _akademisyenFotografDal = akademisyenFotografDal;
        }

        public IResult Add(IFormFile file,AkademisyenFotograf akademisyenFotograf)
        {
            ;
            akademisyenFotograf.FotografYolu = FileHelper.Add(file, "Akademisyen");
            akademisyenFotograf.Tarih = DateTime.Now;
            _akademisyenFotografDal.Add(akademisyenFotograf);

            return new SuccessResult(Messages.KullaniciFotografAdded);
        }

        public IResult Delete(AkademisyenFotograf akademisyenFotograf)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _akademisyenFotografDal.Get(I => I.Id == akademisyenFotograf.Id).FotografYolu;
            _akademisyenFotografDal.Delete(akademisyenFotograf);
            return new SuccessResult(Messages.KullaniciFotografDeleted);
        }

        public IResult Update(IFormFile file, AkademisyenFotograf akademisyenFotograf)
        {

            akademisyenFotograf.FotografYolu = FileHelper.Update(_akademisyenFotografDal.Get(k => k.Id == akademisyenFotograf.Id).FotografYolu, file, "Akademisyen");
            _akademisyenFotografDal.Update(akademisyenFotograf);
            return new SuccessResult(Messages.KullaniciFotografUpdated);
        }

        public IDataResult<List<AkademisyenFotograf>> GetAll()
        {
            return new SuccessDataResult<List<AkademisyenFotograf>>(_akademisyenFotografDal.GetAll(), Messages.KullaniciFotografListed);
        }


        public IDataResult<AkademisyenFotograf> GetById(int Id)
        {
            return new SuccessDataResult<AkademisyenFotograf>(_akademisyenFotografDal.Get(kf =>kf.Id == Id), Messages.KullaniciFotografGeted);
        }

        public IDataResult<AkademisyenFotograf> GetByAkademisyenId(int akademisyenId)
        {
            return new SuccessDataResult<AkademisyenFotograf>(_akademisyenFotografDal.Get(af => af.AkademisyenId == akademisyenId), Messages.KullaniciFotografGeted);
        }
    }
}
