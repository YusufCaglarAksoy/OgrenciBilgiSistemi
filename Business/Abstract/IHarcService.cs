using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IHarcService
    {
        IResult Add(Harc harc);
        IResult Update(Harc harc);
        IResult Delete(int Id);
        IDataResult<List<Harc>> GetAll();
        IDataResult<List<HarcDetayDto>> GetById(int Id);
        IDataResult<List<HarcDetayDto>> GetByOgrenciId(int Id);
        IDataResult<List<HarcDetayDto>> GetAllByHarcDto();
    }
}