using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface INotService
    {
        IResult Add(Not not);
        IResult Delete(int Id);
        IResult Update(Not not);
        IDataResult<List<Not>> GetAll();
        IDataResult<List<NotDetayDto>> GetById(int Id);
        IDataResult<List<NotDetayDto>> GetBySinavId(int sinavId);
        IDataResult<List<NotDetayDto>> GetByOgrenciId(int ogrenciId);
        IDataResult<List<NotDetayDto>> GetAllByNotDto();
    }
}