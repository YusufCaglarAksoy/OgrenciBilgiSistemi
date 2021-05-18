using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface INotService
    {
        IResult Add(Not not);
        IResult Delete(Not not);
        IResult Update(Not not);
        IDataResult<List<Not>> GetAll();
        IDataResult<Not> GetById(int Id);
        IDataResult<List<Not>> GetBySinavId(int sinavId);
        IDataResult<List<Not>> GetByOgrenciId(int ogrenciId);
        IDataResult<List<NotDetayDto>> GetAllByNotDto();
    }
}