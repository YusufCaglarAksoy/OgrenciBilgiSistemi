using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOgrenciService
    {
        IDataResult<Ogrenci> GetById(int Id);
        IDataResult<List<Ogrenci>> GetAll();
        IResult Add(Ogrenci ogrenci);
        IResult Update(Ogrenci ogrenci);
        IResult Delete(Ogrenci ogrenci);
    }

}
