using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISinifListeService
    {
        IResult Add(SinifListe sinifListe);
        IResult Update(SinifListe sinifListe);
        IResult Delete(SinifListe sinifListe);
        IDataResult<List<SinifListe>> GetAll();
        IDataResult<SinifListe> GetById(int Id);
        IDataResult<List<SinifListe>> GetBySubeId(int Id);
        IDataResult<List<SinifListe>> GetByOgrenciId(int Id);
        IDataResult<List<SinifListeDetayDto>> GetAllBySinifListeDto();
    }
}