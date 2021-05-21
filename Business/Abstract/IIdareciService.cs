using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IIdareciService
    {
        IResult Add(IdareciForRegisterDto idareciForRegisterDto);
        IResult Update(IdareciForRegisterDto idareciForRegisterDto);
        IResult Delete(int Id);
        IDataResult<Idareci> Login(LoginDto LoginDto);
        IDataResult<List<Idareci>> GetAll();
        IDataResult<List<IdareciDetayDto>> GetById(int Id);
        IDataResult<List<IdareciDetayDto>> GetBySicilNo(int sicilNo);
        IDataResult<List<IdareciDetayDto>> GetByEMail(string email);
        IDataResult<List<IdareciDetayDto>> GetByUnvanId(int Id);
        IDataResult<List<IdareciDetayDto>> GetAllByIdareciDto();

    }

}
