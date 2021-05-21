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
        IResult Delete(int Id);
        IDataResult<List<SinifListe>> GetAll();
        IDataResult<List<SinifListeDetayDto>> GetById(int Id);
        IDataResult<List<SinifListeDetayDto>> GetBySubeId(int Id);
        IDataResult<List<SinifListeDetayDto>> GetByOgrenciId(int Id);
        IDataResult<List<SinifListeDetayDto>> GetAllBySinifListeDto();
    }
}