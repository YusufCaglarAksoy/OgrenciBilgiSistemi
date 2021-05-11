using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKullaniciFotografService
    {
        IDataResult<KullaniciFotograf> GetByUserId(string Id);
        IDataResult<List<KullaniciFotograf>> GetAll();
        IResult Add(IFormFile file, KullaniciFotograf kullaniciFotograf);
        IResult Update(IFormFile file, KullaniciFotograf kullaniciFotograf);
        IResult Delete(KullaniciFotograf kullaniciFotograf);
        IDataResult<KullaniciFotograf> GetById(string Id);
    }
}
