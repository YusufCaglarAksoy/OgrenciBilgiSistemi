using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace DataAccess.Abstract
{
    public interface IDersDal : IEntityRepository<Ders>
    {
        List<DersDetayDto> GetDersDetaylari(Expression<Func<Ders, bool>> filter = null);
    }
}
