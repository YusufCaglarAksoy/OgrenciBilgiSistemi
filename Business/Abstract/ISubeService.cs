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
        IResult Delete(int Id);
        IDataResult<List<Sube>> GetAll();
        IDataResult<List<SubeDetayDto>> GetById(int Id);
        IDataResult<List<SubeDetayDto>> GetByOgretmenId(int ogretmenid);
        IDataResult<List<SubeDetayDto>> GetByDersId(int dersid);
        IDataResult<List<SubeDetayDto>> GetAllBySubeDto();
    }
}