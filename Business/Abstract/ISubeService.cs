using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISubeService
    {
        IResult Add(Sube sube);
        IResult Update(Sube sube);
        IResult Delete(Sube sube);
        IDataResult<List<Sube>> GetAll();
        IDataResult<Sube> GetById(int Id);
        IDataResult<List<Sube>> GetByOgretmenId(int ogretmenid);
        IDataResult<List<Sube>> GetByDersId(int dersid);
        IDataResult<List<SubeDetayDto>> GetAllBySubeDto();
    }
}