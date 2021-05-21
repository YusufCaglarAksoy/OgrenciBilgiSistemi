using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMufredatService
    {
        IResult Add(Mufredat mufredat);
        IResult Update(Mufredat mufredat);
        IResult Delete(int Id);
        IDataResult<List<Mufredat>> GetAll();
        IDataResult<List<MufredatDetayDto>> GetById(int Id);
        IDataResult<List<MufredatDetayDto>> GetAllByMufredatDto();

    }
}
