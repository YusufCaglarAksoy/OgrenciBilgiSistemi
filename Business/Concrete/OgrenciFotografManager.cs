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
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class OgrenciFotografManager : IOgrenciFotografService
    {
        IOgrenciFotografDal _ogrenciFotografDal;
        public OgrenciFotografManager(IOgrenciFotografDal ogrenciFotografDal)
        {
            _ogrenciFotografDal = ogrenciFotografDal;
        }

        public IResult Add(IFormFile file, OgrenciFotograf ogrenciFotograf)
        {
            ;
            ogrenciFotograf.FotografYolu = FileHelper.Add(file, "Ogrenci");
            ogrenciFotograf.Tarih = DateTime.Now;
            _ogrenciFotografDal.Add(ogrenciFotograf);

            return new SuccessResult(Messages.KullaniciFotografAdded);
        }

        public IResult Delete(OgrenciFotograf ogrenciFotograf)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _ogrenciFotografDal.Get(I => I.Id == ogrenciFotograf.Id).FotografYolu;
            _ogrenciFotografDal.Delete(ogrenciFotograf);
            return new SuccessResult(Messages.KullaniciFotografDeleted);
        }

        public IResult Update(IFormFile file, OgrenciFotograf ogrenciFotograf)
        {

            ogrenciFotograf.FotografYolu = FileHelper.Update(_ogrenciFotografDal.Get(k => k.Id == ogrenciFotograf.Id).FotografYolu, file, "Ogrenci");
            _ogrenciFotografDal.Update(ogrenciFotograf);
            return new SuccessResult(Messages.KullaniciFotografUpdated);
        }

        public IDataResult<List<OgrenciFotograf>> GetAll()
        {
            return new SuccessDataResult<List<OgrenciFotograf>>(_ogrenciFotografDal.GetAll(), Messages.KullaniciFotografListed);
        }


        public IDataResult<OgrenciFotograf> GetById(int Id)
        {
            return new SuccessDataResult<OgrenciFotograf>(_ogrenciFotografDal.Get(idf => idf.Id == Id), Messages.KullaniciFotografGeted);
        }

        public IDataResult<OgrenciFotograf> GetByOgrenciId(int idareciId)
        {
            return new SuccessDataResult<OgrenciFotograf>(_ogrenciFotografDal.Get(of => of.OgrenciId == idareciId), Messages.KullaniciFotografGeted);
        }

        private IResult FotografKontrol(int ogrenciId)
        {
            var result = _ogrenciFotografDal.GetAll(o => o.OgrenciId == ogrenciId).Count();
            if (result > 0)
            {
                return new ErrorResult("Zaten Fotograf Var");
            }
            return new SuccessResult();
        }
    }
}
