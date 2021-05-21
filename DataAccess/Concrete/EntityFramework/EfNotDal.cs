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
    public class EfNotDal : EfEntityRepositoryBase<Not, OBSContext>, INotDal
    {
        public List<NotDetayDto> GetNotDetaylari(Expression<Func<Not, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from n in filter == null ? context.Notlar : context.Set<Not>().Where(filter)
                             join s in context.Sinavlar on n.SinavId equals s.Id
                             join o in context.Ogrenciler on n.OgrenciId equals o.Id
                             join d in context.Dersler on s.DersId equals d.Id
                             join dt in context.Donemler on d.DonemId equals dt.Id
                             join st in context.SinavTurleri on s.SinavTurId equals st.Id
                             select new NotDetayDto
                             {
                                 Id=n.Id,
                                 SinavId=n.SinavId,
                                 OgrenciId=n.OgrenciId,
                                 SinavAdi = st.SinavAdi,
                                 DonemAdi = dt.DonemAdi,
                                 DersAdi = d.DersAdi,
                                 SinavTarihi = s.SinavTarihi,
                                 OgrenciAdi = o.Isim,
                                 OgrenciSoyadi = o.Soyad,
                                 OgrenciNo = o.OgrenciNo,
                                 SinavNot = n.SinavNot
                             };
                return result.ToList();
            }
        }
    }
}
