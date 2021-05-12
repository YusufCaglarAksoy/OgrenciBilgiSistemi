using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISinifListeService
    {
        IDataResult<SinifListe> GetById(string Id);
        IDataResult<List<SinifListe>> GetAll();
        IResult Add(SinifListe sinifListe);
        IResult Update(SinifListe sinifListe);
        IResult Delete(SinifListe sinifListe);

    }
}