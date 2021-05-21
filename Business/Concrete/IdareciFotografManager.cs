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
    public class IdareciFotografManager : IIdareciFotografService
    {
        IIdareciFotografDal _idareciFotografDal;
        public IdareciFotografManager(IIdareciFotografDal idareciFotografDal)
        {
            _idareciFotografDal = idareciFotografDal;
        }

        public IResult Add(IFormFile file, IdareciFotograf idarecifotograf)
        {
            ;
            idarecifotograf.FotografYolu = FileHelper.Add(file, "Idareci");
            idarecifotograf.Tarih = DateTime.Now;
            _idareciFotografDal.Add(idarecifotograf);

            return new SuccessResult(Messages.KullaniciFotografAdded);
        }

        public IResult Delete(IdareciFotograf idarecifotograf)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _idareciFotografDal.Get(I => I.Id == idarecifotograf.Id).FotografYolu;
            _idareciFotografDal.Delete(idarecifotograf);
            return new SuccessResult(Messages.KullaniciFotografDeleted);
        }

        public IResult Update(IFormFile file, IdareciFotograf idarecifotograf)
        {

            idarecifotograf.FotografYolu = FileHelper.Update(_idareciFotografDal.Get(k => k.Id == idarecifotograf.Id).FotografYolu, file, "Idareci");
            _idareciFotografDal.Update(idarecifotograf);
            return new SuccessResult(Messages.KullaniciFotografUpdated);
        }

        public IDataResult<List<IdareciFotograf>> GetAll()
        {
            return new SuccessDataResult<List<IdareciFotograf>>(_idareciFotografDal.GetAll(), Messages.KullaniciFotografListed);
        }


        public IDataResult<IdareciFotograf> GetById(int Id)
        {
            return new SuccessDataResult<IdareciFotograf>(_idareciFotografDal.Get(idf => idf.Id == Id), Messages.KullaniciFotografGeted);
        }

        public IDataResult<IdareciFotograf> GetByIdareciId(int idareciId)
        {
            return new SuccessDataResult<IdareciFotograf>(_idareciFotografDal.Get(idf => idf.IdareciId == idareciId), Messages.KullaniciFotografGeted);
        }

        private IResult FotografKontrol(int idareciId)
        {
            var result = _idareciFotografDal.GetAll(i => i.IdareciId == idareciId).Count();
            if (result > 0)
            {
                return new ErrorResult("Zaten Fotograf Var");
            }
            return new SuccessResult();
        }
    }
}
