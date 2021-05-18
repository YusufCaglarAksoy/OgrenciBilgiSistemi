using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace DataAccess.Abstract
{
    public interface IMufredatDal : IEntityRepository<Mufredat>
    {
        List<MufredatDetayDto> GetMufredatDetaylari(Expression<Func<Mufredat, bool>> filter = null);
    }
}
