using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISubeService
    {
        IDataResult<Sube> GetById(int Id);
        IDataResult<List<Sube>> GetAll();
        IResult Add(Sube sube);
        IResult Update(Sube sube);
        IResult Delete(Sube sube);
    }
}