using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IIdareciService
    {
        IDataResult<Idareci> GetById(int Id);
        IDataResult<List<Idareci>> GetAll();
        IResult Add(Idareci idareci);
        IResult Update(Idareci idareci);
        IResult Delete(Idareci idareci);
        IDataResult<Idareci> GetBySicilNo(int sicilNo);
        IDataResult<Idareci> GetByEMail(string email);
        IDataResult<List<Idareci>> GetByUnvanId(int Id);
    }

}
