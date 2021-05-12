using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBolumService
    {
        IDataResult<Bolum> GetById(int Id);
        IDataResult<List<Bolum>> GetAll();
        IResult Add(Bolum bolum);
        IResult Update(Bolum bolum);
        IResult Delete(Bolum bolum);
    }
}
