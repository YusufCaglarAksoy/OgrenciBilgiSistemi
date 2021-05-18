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
        IResult Delete(Harc harc);
        IDataResult<List<Harc>> GetAll();
        IDataResult<Harc> GetById(int Id);
        IDataResult<Harc> GetByOgrenciId(int Id);
        IDataResult<List<HarcDetayDto>> GetAllByHarcDto();
    }
}