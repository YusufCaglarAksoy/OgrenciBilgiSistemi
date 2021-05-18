using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAkademisyenService
    {
        IResult Add(AkademisyenForRegisterDto akademisyenForRegisterDTO);
        IResult Update(AkademisyenForRegisterDto akademisyenForRegisterDTO);
        IResult Delete(int Id);
        IDataResult<Akademisyen> Login(LoginDto LoginDto);
        IDataResult<List<Akademisyen>> GetAll();
        IDataResult<List<Akademisyen>> GetByBolumId(int bolumId);
        IDataResult<Akademisyen> GetById(int Id);
        IDataResult<Akademisyen> GetBySicilNo(int sicilNo);
        IDataResult<Akademisyen> GetByEMail(string email);
        IDataResult<List<Akademisyen>> GetByUnvanId(int Id);
        IDataResult<List<AkademisyenDetayDto>> GetAllByAkademisyenDto();
    }

}
