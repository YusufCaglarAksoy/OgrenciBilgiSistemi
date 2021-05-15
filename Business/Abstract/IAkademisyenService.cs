using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAkademisyenService
    {
        IDataResult<List<Akademisyen>> GetByBolumId(int Id);
        IDataResult<Akademisyen> GetBySicilNo(int sicilNo);
        IDataResult<Akademisyen> GetByEMail(string email);
        IDataResult<List<Akademisyen>> GetByUnvanId(int Id);
        IDataResult<List<Akademisyen>> GetAll();
        IResult Add(Akademisyen akademisyen);
        IResult Update(Akademisyen akademisyen);
        IResult Delete(Akademisyen akademisyen);
    }

}
