using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace DataAccess.Abstract
{
    public interface IIdareciDal : IEntityRepository<Idareci>
    {
        List<IdareciDetayDto> GetIdareciDetaylari(Expression<Func<Idareci, bool>> filter = null);
    }
}
