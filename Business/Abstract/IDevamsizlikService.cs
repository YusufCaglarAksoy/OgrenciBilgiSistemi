using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDevamsizlikService
    {
        IResult Add(Devamsizlik devamsizlik);
        IResult Update(Devamsizlik devamsizlik);
        IResult Delete(Devamsizlik devamsizlik);
        IDataResult<List<Devamsizlik>> GetAll();
        IDataResult<Devamsizlik> GetById(int Id);
        IDataResult<List<Devamsizlik>> GetByOgrenciId(int ogrenciId);
        IDataResult<List<Devamsizlik>> GetByDersId(int dersId);
        IDataResult<List<Devamsizlik>> GetByDevamsizlikDurumu(bool devamsizlikDurumu);
        IDataResult<List<DevamsizlikDetayDto>> GetAllByDevamsizlikDto();
    }
}
