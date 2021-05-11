using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDersService
    {
        IDataResult<Ders> GetById(string Id);
        IDataResult<List<Ders>> GetAll();
        IResult Add(Ders ders);
        IResult Delete(Ders ders);
        IResult Update(Ders ders);

    }
}
