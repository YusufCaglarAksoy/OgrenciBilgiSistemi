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
        IResult Delete(Mufredat mufredat);
        IDataResult<List<Mufredat>> GetAll();
        IDataResult<Mufredat> GetById(int Id);
        IDataResult<List<MufredatDetayDto>> GetAllByMufredatDto();

    }
}
