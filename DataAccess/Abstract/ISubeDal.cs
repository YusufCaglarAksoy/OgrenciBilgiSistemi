using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace DataAccess.Abstract
{
    public interface ISubeDal : IEntityRepository<Sube>
    {
        List<SubeDetayDto> GetSubeDetaylari(Expression<Func<Sube, bool>> filter = null);
    }
}
