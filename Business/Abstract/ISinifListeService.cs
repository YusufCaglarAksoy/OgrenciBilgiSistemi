using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISinifListeService
    {
        IDataResult<SinifListe> GetById(int Id);
        IDataResult<List<SinifListe>> GetAll();
        IResult Add(SinifListe sinifListe);
        IResult Update(SinifListe sinifListe);
        IResult Delete(SinifListe sinifListe);
        IDataResult<List<SinifListe>> GetBySubeId(int Id);
        IDataResult<List<SinifListe>> GetByOgrenciId(int Id);

    }
}