using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IHarcService
    {
        IDataResult<Harc> GetById(int Id);
        IDataResult<List<Harc>> GetAll();
        IResult Add(Harc harc);
        IResult Update(Harc harc);
        IResult Delete(Harc harc);
        IDataResult<Harc> GetByOgrenciId(int Id);
    }
}