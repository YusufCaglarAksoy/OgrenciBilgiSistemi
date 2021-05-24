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
    public class EfSinavDal : EfEntityRepositoryBase<Sinav, OBSContext>, ISinavDal
    {
        public List<SinavDetayDto> GetSinavDetaylari(Expression<Func<Sinav, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from s in filter == null ? context.Sinavlar : context.Set<Sinav>().Where(filter)
                             join d in context.Dersler on s.DersId equals d.Id
                             join st in context.SinavTurleri on s.SinavTurId equals st.Id
                             select new SinavDetayDto
                             {
                                 Id = s.Id,
                                 SinavTurId = s.SinavTurId,
                                 DersId = s.DersId,
                                 SinavAdi = st.SinavAdi,
                                 SinavTarihi = s.SinavTarihi,
                                 DersAdi = d.DersAdi,
                                 DersKodu = d.DersKodu,
                                 AkademisyenId = s.AkademisyenId
                             };
                return result.ToList();
            }
        }
    }
}
