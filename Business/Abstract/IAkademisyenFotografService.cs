using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAkademisyenFotografService
    {
        IResult Add(IFormFile file, AkademisyenFotograf akademisyenFotograf);
        IResult Update(IFormFile file, AkademisyenFotograf akademisyenFotograf);
        IResult Delete(AkademisyenFotograf akademisyenFotograf);
        IDataResult<List<AkademisyenFotograf>> GetAll();
        IDataResult<AkademisyenFotograf> GetById(int Id);
        IDataResult<AkademisyenFotograf> GetByAkademisyenId(int akademisyenId);
        
    }
}
