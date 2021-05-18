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
    public class EfSubeDal : EfEntityRepositoryBase<Sube, OBSContext>, ISubeDal
    {
        public List<SubeDetayDto> GetSubeDetaylari(Expression<Func<Sube, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from s in filter == null ? context.Subeler : context.Set<Sube>().Where(filter)
                             join d in context.Dersler on s.DersId equals d.Id
                             join a in context.Akademisyenler on s.OgretmenId equals a.Id
                             select new SubeDetayDto
                             {
                                DersAdi = d.DersAdi,
                                DersKodu =d.DersKodu,
                                OgretmenAdi = a.Isim,
                                OgretmenMail = a.EMail,
                                OgretmenSoyadi = a.Soyad
                             };
                return result.ToList();
            }
        }
    }




}
