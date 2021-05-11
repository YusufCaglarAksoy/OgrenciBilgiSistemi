using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DersManager : IDersService
    {
        IDersDal _dersDal;

        public DersManager(IDersDal dersDal)
        {
            _dersDal = dersDal;
        }

        public IResult Add(Ders ders)
        {
            _dersDal.Add(ders);
            return new Result(true, Messages);
        }

        public IResult Delete(Ders ders)
        {
            _dersDal.Delete(ders);
            return new Result(true, Messages);
        }

        public IDataResult<List<Ders>> GetAll()
        {
            return new SuccessDataResult<List<Ders>>(_dersDal.GetAll(), Messages);
        }

        public IDataResult<Ders> GetById(string Id)
        {
            return new SuccessDataResult<Ders>(_dersDal.Get(d => d.DersId == Id), Messages);
        }

        public IResult Update(Ders ders)
        {
            Ogrenci og = new Ogrenci();
            _dersDal.Update(ders);
            return new Result(true, Messages);
        }

    }
}

