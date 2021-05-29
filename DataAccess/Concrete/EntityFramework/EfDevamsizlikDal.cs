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
    public class EfDevamsizlikDal : EfEntityRepositoryBase<Devamsizlik, OBSContext>, IDevamsizlikDal
    {
        public List<DevamsizlikDetayDto> GetDevamsizlikDetaylari(Expression<Func<Devamsizlik, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from d in filter == null ? context.Devamsizliklar : context.Set<Devamsizlik>().Where(filter)
                             join ders in context.Dersler on d.DersId equals ders.Id
                             join o in context.Ogrenciler on d.OgrenciId equals o.Id
                             select new DevamsizlikDetayDto
                             {
                                 Id=d.Id,
                                 DersId=d.DersId,
                                 OgrenciId=d.OgrenciId,
                                 OgrenciAdi = o.Isim,
                                 OgrenciSoyadi = o.Soyad,
                                 OgrenciMail = o.EMail,
                                 OgrenciNo = o.OgrenciNo,
                                 DersAdi = ders.DersAdi,
                                 DersKodu = ders.DersKodu,
                                 Sinif = ders.Sinif,
                                 DevamsizlikDurumu = d.DevamsizlikDurumu
                             };
                return result.ToList();
            }
        }
    }
}
