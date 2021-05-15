using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOgrenciService
    {
        IDataResult<Ogrenci> GetByOgrenciNo(int ogrenciNo);
        IDataResult<List<Ogrenci>> GetByBolumId(int Id);
        IDataResult<List<Ogrenci>> GetByDanismanId(int Id);
        IDataResult<Ogrenci> GetByEMail(string email);
        IDataResult<List<Ogrenci>> GetAll();
        IResult Add(Ogrenci ogrenci);
        IResult Update(Ogrenci ogrenci);
        IResult Delete(Ogrenci ogrenci);
        IDataResult<List<OgrenciDetayDTO>> GetAllByOgrenciDto();
    }

}
