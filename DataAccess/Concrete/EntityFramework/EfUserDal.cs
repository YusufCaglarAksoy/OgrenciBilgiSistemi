using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<Kullanici, OBSContext>, IUserDal
    {
        public List<Unvan> GetClaims(Kullanici kullanici)
        {
            using (var context = new OBSContext())
            {
                var result = from u in context.Unvanlar
                             join uk in context.Unvanlar on kullanici.UnvanId equals uk.Id
                             select new Unvan 
                             { 
                                 Id=uk.Id,
                                 UnvanAdi=uk.UnvanAdi,
                             };
                return result.ToList();

            }
        }
    }
}
