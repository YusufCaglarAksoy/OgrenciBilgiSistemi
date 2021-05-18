using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOgrenciService
    {
        IResult Add(OgrenciForRegisterDto ogrenciForRegisterDto);
        IResult Update(OgrenciForRegisterDto ogrenciForRegisterDto);
        IResult Delete(int Id);
        IDataResult<Ogrenci> Login(LoginDto LoginDto);
        IDataResult<List<Ogrenci>> GetAll();
        IDataResult<Ogrenci> GetByOgrenciNo(int ogrenciNo);
        IDataResult<Ogrenci> GetById(int Id);
        IDataResult<List<Ogrenci>> GetByBolumId(int Id);
        IDataResult<List<Ogrenci>> GetByDanismanId(int Id);
        IDataResult<Ogrenci> GetByEMail(string email);
        IDataResult<List<OgrenciDetayDto>> GetAllByOgrenciDto();

    }

}
