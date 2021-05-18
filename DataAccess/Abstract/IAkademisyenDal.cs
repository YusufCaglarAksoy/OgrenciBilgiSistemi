using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IAkademisyenDal : IEntityRepository<Akademisyen>
    {
        List<AkademisyenDetayDto> GetAkademisyenDetaylari(Expression<Func<Akademisyen, bool>> filter = null);
    }
}
