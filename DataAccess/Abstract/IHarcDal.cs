using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IHarcDal : IEntityRepository<Harc>
    {
        List<HarcDetayDto> GetHarcDetaylari(Expression<Func<Harc, bool>> filter = null);
    }
}
