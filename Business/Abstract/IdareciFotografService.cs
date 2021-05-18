using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IIdareciFotografService
    {
        IResult Add(IFormFile file, IdareciFotograf idareciFotograf);
        IResult Update(IFormFile file, IdareciFotograf idareciFotograf);
        IResult Delete(IdareciFotograf idareciFotograf);
        IDataResult<List<IdareciFotograf>> GetAll();
        IDataResult<IdareciFotograf> GetById(int Id);
        IDataResult<IdareciFotograf> GetByIdareciId(int idareciId);

    }
}
