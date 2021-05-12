using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMufredatService
    {
        IDataResult<Mufredat> GetById(int Id);
        IDataResult<List<Mufredat>> GetAll();
        IResult Add(Mufredat mufredat);
        IResult Update(Mufredat mufredat);
        IResult Delete(Mufredat mufredat);
    }
}
