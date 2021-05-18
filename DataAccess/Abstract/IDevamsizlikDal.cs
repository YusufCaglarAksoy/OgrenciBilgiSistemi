using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IDevamsizlikDal : IEntityRepository<Devamsizlik>
    {
        List<DevamsizlikDetayDto> GetDevamsizlikDetaylari(Expression<Func<Devamsizlik, bool>> filter = null);
    }
}
