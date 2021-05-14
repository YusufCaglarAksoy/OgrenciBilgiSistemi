using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class OBSContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OgrenciBilgiSistemi;Trusted_Connection=true");
        }

        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }
        public DbSet<Akademisyen> Akademisyenler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Idareci> Idareciler { get; set; }
    }
}
