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
    public class EfMufredatDal : EfEntityRepositoryBase<Mufredat, OBSContext>, IMufredatDal
    {
        public List<MufredatDetayDto> GetMufredatDetaylari(Expression<Func<Mufredat, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from m in filter == null ? context.Mufredatlar : context.Set<Mufredat>().Where(filter)
                             join d in context.Dersler on m.DersId equals d.Id
                             join dt in context.Donemler on d.DonemId equals dt.Id
                             select new MufredatDetayDto
                             {
                                 Id=m.Id,
                                 DersId=m.DersId,
                                 DonemAdi=dt.DonemAdi,
                                 MufredatId = m.MufredatId,
                                 DersAdi = d.DersAdi,
                                 DersKodu = d.DersKodu
                             };
                return result.ToList();
            }
        }
    }
}
