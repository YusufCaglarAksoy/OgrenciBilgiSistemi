using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISinavService
    {
        IResult Add(Sinav sinav);
        IResult Update(Sinav sinav);
        IResult Delete(Sinav sinav);
        IDataResult<List<Sinav>> GetAll();
        IDataResult<Sinav> GetById(int Id);
        IDataResult<List<SinavDetayDto>> GetAllBySinavDto();
    }
}
