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
    public class EfHarcDal : EfEntityRepositoryBase<Harc, OBSContext>, IHarcDal
    {
        public List<HarcDetayDto> GetHarcDetaylari(Expression<Func<Harc, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from h in filter == null ? context.Harclar : context.Set<Harc>().Where(filter)
                             join o in context.Ogrenciler on h.OgrenciId equals o.Id
                             select new HarcDetayDto
                             {
                                 OgrenciAdi = o.Isim,
                                 OgrenciSoyadi = o.Soyad,
                                 OgrenciMail = o.EMail,
                                 OgrenciNo = o.OgrenciNo,
                                 Donem = h.Donem,
                                 Tipi = h.Tipi,
                                 Turu = h.Turu,
                                 TahakkukTarihi = h.TahakkukTarihi,
                                 OdemeTarihi = h.OdemeTarihi,
                                 Tutar = h.Tutar
                             };
                return result.ToList();
            }
        }
    }
}
