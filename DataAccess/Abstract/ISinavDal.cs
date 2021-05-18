using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace DataAccess.Abstract
{
    public interface ISinavDal : IEntityRepository<Sinav>
    {
        List<SinavDetayDto> GetSinavDetaylari(Expression<Func<Sinav, bool>> filter = null);
    }
}