using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class OBSContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CarRental;Trusted_Connection=true");
        }

        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciFotograf> KullaniciFotograflar { get; set; }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }

    }
}
