using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IBolumDal : IEntityRepository<Bolum>
    {
        List<BolumDetayDto> GetBolumDetaylari(Expression<Func<Bolum, bool>> filter = null);
    }
}
