using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ISinifListeDal : IEntityRepository<SinifListe>
    {
        List<SinifListeDetayDto> GetSinifListeDetaylari(Expression<Func<SinifListe, bool>> filter = null);
    }
}
