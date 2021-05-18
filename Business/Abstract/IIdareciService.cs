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
        IDataResult<Idareci> GetById(int Id);
        IDataResult<Idareci> GetBySicilNo(int sicilNo);
        IDataResult<Idareci> GetByEMail(string email);
        IDataResult<List<Idareci>> GetByUnvanId(int Id);
        IDataResult<List<IdareciDetayDto>> GetAllByIdareciDto();

    }

}
