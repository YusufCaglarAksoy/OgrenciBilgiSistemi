using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAkademisyenService
    {
        IDataResult<Akademisyen> GetById(int Id);
        IDataResult<List<Akademisyen>> GetAll();
        IResult Add(Akademisyen akademisyen);
        IResult Update(Akademisyen akademisyen);
        IResult Delete(Akademisyen akademisyen);
    }

}
