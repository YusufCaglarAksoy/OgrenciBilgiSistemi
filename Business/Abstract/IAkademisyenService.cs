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
        IDataResult<List<AkademisyenDetayDto>> GetByBolumId(int bolumId);
        IDataResult<List<AkademisyenDetayDto>> GetById(int Id);
        IDataResult<List<AkademisyenDetayDto>> GetBySicilNo(int sicilNo);
        IDataResult<List<AkademisyenDetayDto>> GetByEMail(string email);
        IDataResult<List<AkademisyenDetayDto>> GetByUnvanId(int Id);
        IDataResult<List<AkademisyenDetayDto>> GetAllByAkademisyenDto();
    }

}
