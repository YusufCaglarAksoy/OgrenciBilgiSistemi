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

            return new SuccessDataResult<Idareci>(_idareciDal.Get(a => a.Id == Id), Messages.IdareciGeted);
        }

        public IResult Add(Idareci akademisyen)
        {
            _idareciDal.Add(akademisyen);
            return new Result(true, Messages.IdareciAdded);
        }

        public IResult Delete(Idareci akademisyen)
        {
            _idareciDal.Delete(akademisyen);
            return new Result(true, Messages.IdareciDeleted);
        }

        public IResult Update(Idareci akademisyen)
        {
            _idareciDal.Update(akademisyen);
            return new Result(true, Messages.IdareciUpdated);
        }

        public IDataResult<List<Idareci>> GetAll()
        {
            return new SuccessDataResult<List<Idareci>>(_idareciDal.GetAll(), Messages.IdareciListed);
        }

        public IDataResult<Idareci> GetBySicilNo(int sicilNo)
        {
            return new SuccessDataResult<Idareci>(_idareciDal.Get(i => i.SicilNo == sicilNo), Messages.IdareciGeted);
        }

        public IDataResult<Idareci> GetByEMail(string email)
        {
            return new SuccessDataResult<Idareci>(_idareciDal.Get(i => i.EMail == email), Messages.IdareciGeted);
        }

        public IDataResult<List<Idareci>> GetByUnvanId(int Id)
        {
            return new SuccessDataResult<List<Idareci>>(_idareciDal.GetAll(i => i.UnvanId == Id), Messages.IdareciGeted);
        }
    }

}

