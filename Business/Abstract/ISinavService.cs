using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISinavService
    {
        IDataResult<Sinav> GetById(string Id);
        IDataResult<List<Sinav>> GetAll();
        IResult Add(Sinav sinav);
        IResult Update(Sinav sinav);
        IResult Delete(Sinav sinav);
    }
}
