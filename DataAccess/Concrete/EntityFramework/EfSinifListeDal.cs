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
    public class EfSinifListeDal : EfEntityRepositoryBase<SinifListe, OBSContext>, ISinifListeDal
    {
        public List<SinifListeDetayDto> GetSinifListeDetaylari(Expression<Func<SinifListe, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from sl in filter == null ? context.SinifListeleri : context.Set<SinifListe>().Where(filter)
                             join o in context.Ogrenciler on sl.OgrenciId equals o.Id
                             join s in context.Subeler on sl.SubeId equals s.Id
                             join a in context.Akademisyenler on s.OgretmenId equals a.Id
                             join d in context.Dersler on s.DersId equals d.Id
                             select new SinifListeDetayDto
                             {
                                 Id=sl.Id,
                                 OgrenciId=sl.OgrenciId,
                                 SubeId=sl.SubeId,
                                 OgretmenAdi= a.Isim,
                                 OgretmenSoyadi=a.Soyad,
                                 OgretmenMail =a.EMail,
                                 DersAdi = d.DersAdi,
                                 OgrenciAdi = o.Isim,
                                 OgrenciNo =o.OgrenciNo,
                                 OgrenciMail = o.EMail,
                                 OgrenciSoyadi = o.Soyad
                             };
                return result.ToList();
            }
        }
    }
}
