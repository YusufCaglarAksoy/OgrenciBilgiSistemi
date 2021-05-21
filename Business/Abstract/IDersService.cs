using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDersService
    {
        IResult Add(Ders ders);
        IResult Delete(int Id);
        IResult Update(Ders ders);
        IDataResult<List<Ders>> GetAll();
        IDataResult<List<DersDetayDto>> GetById(int Id);
        IDataResult<List<DersDetayDto>> GetByDersKodu(string Id);
        IDataResult<List<DersDetayDto>> GetAllByDersDto();

    }
}