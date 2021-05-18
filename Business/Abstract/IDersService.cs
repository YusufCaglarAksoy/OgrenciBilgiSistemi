using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDersService
    {
        IResult Add(Ders ders);
        IResult Delete(Ders ders);
        IResult Update(Ders ders);
        IDataResult<List<Ders>> GetAll();
        IDataResult<Ders> GetById(int Id);
        IDataResult<Ders> GetByDersKodu(string Id);
        IDataResult<List<DersDetayDto>> GetAllByDersDto();

    }
}