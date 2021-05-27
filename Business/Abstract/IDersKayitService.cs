using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDersKayitService
    {
        IDataResult<List<DersKayitDetayDto>> GetById(int Id);
        IDataResult<List<DersKayitDetayDto>> GetAll();
        IResult Add(DersKayit dersKayit);
        IResult Update(DersKayit dersKayit);
        IResult Delete(int Id);
        IDataResult<List<DersKayitDetayDto>> GetByOgrenciId(int ogrenciId);
        IDataResult<List<DersKayitDetayDto>> GetByDanismanId(int ogrenciId);
    }
}
