using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class IdareciManager : IKullaniciService, IIdareciService
    {
        IIdareciDal _idareciDal;

        public IdareciManager(IIdareciDal idareciDal)
        {
            _idareciDal = idareciDal;
        }

        public IDataResult<Idareci> GetById(int Id)
        {

            return new SuccessDataResult<Idareci>(_idareciDal.Get(a => a.KullaniciId == Id), Messages.AkademisyenGeted);
        }

        public IResult Add(Idareci akademisyen)
        {
            _idareciDal.Add(akademisyen);
            return new Result(true, Messages.AkademisyenAdded);
        }

        public IResult Delete(Idareci akademisyen)
        {
            _idareciDal.Delete(akademisyen);
            return new Result(true, Messages.AkademisyenDeleted);
        }

        public IResult Update(Idareci akademisyen)
        {
            _idareciDal.Update(akademisyen);
            return new Result(true, Messages.AkademisyenUpdated);
        }

        public IDataResult<List<Idareci>> GetAll()
        {
            return new SuccessDataResult<List<Idareci>>(_idareciDal.GetAll(), Messages.AkademisyenListed);
        }
    }

}

