using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBolumDal : EfEntityRepositoryBase<Bolum, OBSContext>, IBolumDal
    {
        public List<BolumDetayDto> GetBolumDetaylari(Expression<Func<Bolum, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from b in filter == null ? context.Bolumler : context.Set<Bolum>().Where(filter)
                             join f in context.Fakulteler on b.FakulteId equals f.Id
                             select new BolumDetayDto
                             {
                                 BolumAdi = b.BolumAdi,
                                 FakulteAdi = f.FakulteAdi
                             };
                return result.ToList();
            }
        }
    }
}
