using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBolumService
    {
        IResult Add(Bolum bolum);
        IResult Update(Bolum bolum);
        IResult Delete(int Id);
        IDataResult<List<Bolum>> GetAll();
        IDataResult<List<BolumDetayDto>> GetById(int Id);
        IDataResult<List<BolumDetayDto>> GetByFakulteId(int Id);
        IDataResult<List<BolumDetayDto>> GetAllByBolumDto();
    }
}
