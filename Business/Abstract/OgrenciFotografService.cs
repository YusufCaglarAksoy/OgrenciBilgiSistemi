using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOgrenciFotografService
    {
        IResult Add(IFormFile file, OgrenciFotograf ogrenciFotograf);
        IResult Update(IFormFile file, OgrenciFotograf ogrenciFotograf);
        IResult Delete(OgrenciFotograf ogrenciFotograf);
        IDataResult<List<OgrenciFotograf>> GetAll();
        IDataResult<OgrenciFotograf> GetById(int Id);
        IDataResult<OgrenciFotograf> GetByOgrenciId(int ogrenciId);
    }
}
