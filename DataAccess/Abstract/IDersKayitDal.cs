using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IDersKayitDal : IEntityRepository<DersKayit>
    {
        List<DersKayitDetayDto> GetDersKayitDetaylari(Expression<Func<DersKayit, bool>> filter = null);
    }
}
