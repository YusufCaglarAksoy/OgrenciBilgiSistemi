using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface INotService
    {
        IDataResult<Not> GetById(int Id);
        IDataResult<List<Not>> GetAll();
        IResult Add(Not not);
        IResult Delete(Not not);
        IResult Update(Not not);
        IDataResult<List<Not>> GetBySinavId(int Id);
        IDataResult<List<Not>> GetByDersId(int Id);
        IDataResult<List<Not>> GetByOgrenciId(int Id);
    }
}