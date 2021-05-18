using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface INotDal : IEntityRepository<Not>
    {
        List<NotDetayDto> GetNotDetaylari(Expression<Func<Not, bool>> filter = null);
    }
}