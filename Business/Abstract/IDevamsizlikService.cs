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
        IResult Delete(int Id);
        IDataResult<List<Devamsizlik>> GetAll();
        IDataResult<List<DevamsizlikDetayDto>> GetById(int Id);
        IDataResult<List<DevamsizlikDetayDto>> GetByOgrenciId(int ogrenciId);
        IDataResult<List<DevamsizlikDetayDto>> GetByDersId(int dersId);
        IDataResult<List<DevamsizlikDetayDto>> GetByDevamsizlikDurumu(bool devamsizlikDurumu);
        IDataResult<List<DevamsizlikDetayDto>> GetAllByDevamsizlikDto();
    }
}
