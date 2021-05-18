using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFakulteService
    {
        IResult Add(Fakulte fakulte);
        IResult Update(Fakulte fakulte);
        IResult Delete(Fakulte fakulte);
        IDataResult<List<Fakulte>> GetAll();
        IDataResult<Fakulte> GetById(int Id);
    }
}
