using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDersService
    {
        IDataResult<Ders> GetById(int Id);
        IDataResult<List<Ders>> GetAll();
        IResult Add(Ders ders);
        IResult Delete(Ders ders);
        IResult Update(Ders ders);

    }
}