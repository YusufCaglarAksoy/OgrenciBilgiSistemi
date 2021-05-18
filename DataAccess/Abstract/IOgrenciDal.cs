using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IOgrenciDal : IEntityRepository<Ogrenci>
    {
        List<OgrenciDetayDto> GetOgrenciDetaylari(Expression<Func<Ogrenci, bool>> filter = null);
    }
}
