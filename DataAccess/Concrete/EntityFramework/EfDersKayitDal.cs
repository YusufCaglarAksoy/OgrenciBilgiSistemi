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
    public class EfDersKayitDal : EfEntityRepositoryBase<DersKayit, OBSContext>, IDersKayitDal
    {
        public List<DersKayitDetayDto> GetDersKayitDetaylari(Expression<Func<DersKayit, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from d in filter == null ? context.DersKayitlar : context.Set<DersKayit>().Where(filter)
                             join d1 in context.Dersler on d.DersId1 equals d1.Id
                             join d2 in context.Dersler on d.DersId2 equals d2.Id
                             join d3 in context.Dersler on d.DersId3 equals d3.Id
                             join d4 in context.Dersler on d.DersId4 equals d4.Id
                             join d5 in context.Dersler on d.DersId5 equals d5.Id
                             join d6 in context.Dersler on d.DersId6 equals d6.Id
                             join d7 in context.Dersler on d.DersId7 equals d7.Id
                             join d8 in context.Dersler on d.DersId8 equals d8.Id
                             join d9 in context.Dersler on d.DersId9 equals d9.Id
                             join d10 in context.Dersler on d.DersId10 equals d10.Id
                             join o in context.Ogrenciler on d.OgrenciId equals o.Id
                             join a in context.Akademisyenler on d.DanismanId equals a.Id
                             select new DersKayitDetayDto
                             {
                                 Id = d.Id,
                                 DersId1 = d1.Id,
                                 DersAdi1 = d1.DersAdi,
                                 DersKodu1 = d1.DersKodu,
                                 DersId2 = d2.Id,
                                 DersAdi2 = d2.DersAdi,
                                 DersKodu2 = d2.DersKodu,
                                 DersId3 = d3.Id,
                                 DersAdi3 = d3.DersAdi,
                                 DersKodu3 = d3.DersKodu,
                                 DersId4 = d4.Id,
                                 DersAdi4 = d4.DersAdi,
                                 DersKodu4 = d4.DersKodu,
                                 DersId5 = d5.Id,
                                 DersAdi5 = d5.DersAdi,
                                 DersKodu5 = d5.DersKodu,
                                 DersId6 = d6.Id,
                                 DersAdi6 = d6.DersAdi,
                                 DersKodu6 = d6.DersKodu,
                                 DersId7 = d7.Id,
                                 DersAdi7 = d7.DersAdi,
                                 DersKodu7 = d7.DersKodu,
                                 DersId8 = d8.Id,
                                 DersAdi8 = d8.DersAdi,
                                 DersKodu8 = d8.DersKodu,
                                 DersId9 = d9.Id,
                                 DersAdi9 = d9.DersAdi,
                                 DersKodu9 = d9.DersKodu,
                                 DersId10 = d10.Id,
                                 DersAdi10 = d10.DersAdi,
                                 DersKodu10 = d10.DersKodu,
                                 OgrenciId = o.Id,
                                 OgrenciAdi = o.Isim,
                                 OgrenciSoyadi = o.Soyad,
                                 OgrenciNo = o.OgrenciNo,
                                 OgrenciMail = o.EMail,
                                 DanismanId = a.Id,
                                 DanismanAdi = a.Isim,
                                 DanismanMail = a.EMail,
                                 DanismanSoyadi = a.Soyad

                             };
                return result.ToList();
            }
        }
    }


}
