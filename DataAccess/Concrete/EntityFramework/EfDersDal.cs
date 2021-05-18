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
    public class EfDersDal : EfEntityRepositoryBase<Ders, OBSContext>, IDersDal
    {
        public List<DersDetayDto> GetDersDetaylari(Expression<Func<Ders, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from d in filter == null ? context.Dersler : context.Set<Ders>().Where(filter)
                             join b in context.Bolumler on d.BolumId equals b.Id
                             join f in context.Fakulteler on b.FakulteId equals f.Id
                             join dt in context.Donemler on d.DonemId equals dt.Id
                             select new DersDetayDto
                             {
                                 DonemAdi = dt.DonemAdi,
                                 DersKodu = d.DersKodu,
                                 DersAdi = d.DersAdi,
                                 Sinif = d.Sinif,
                                 BolumAdi = b.BolumAdi,
                                 FakulteAdi = f.FakulteAdi

                             };
                return result.ToList();
            }
        }
    }




}
