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
        IDataResult<List<OgrenciDetayDto>> GetByOgrenciNo(int ogrenciNo);
        IDataResult<List<OgrenciDetayDto>> GetById(int Id);
        IDataResult<List<OgrenciDetayDto>> GetByBolumId(int Id);
        IDataResult<List<OgrenciDetayDto>> GetByDanismanId(int Id);
        IDataResult<List<OgrenciDetayDto>> GetByEMail(string email);
        IDataResult<List<OgrenciDetayDto>> GetAllByOgrenciDto();

    }

}
