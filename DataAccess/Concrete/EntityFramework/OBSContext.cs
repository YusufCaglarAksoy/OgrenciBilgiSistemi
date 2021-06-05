using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class OBSContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:webapidbservera.database.windows.net,1433;Initial Catalog=OgrenciBilgiSistemi;Persist Security Info=False;User ID=*******;Password=********;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;");
        }

        public DbSet<Akademisyen> Akademisyenler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Devamsizlik> Devamsizliklar { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<Harc> Harclar { get; set; }
        public DbSet<Idareci> Idareciler { get; set; }
        public DbSet<AkademisyenFotograf> AkademisyenFotograflar { get; set; }
        public DbSet<IdareciFotograf> IdareciFotograflar { get; set; }
        public DbSet<OgrenciFotograf> OgrenciFotograflar { get; set; }
        public DbSet<Mail> Mailler { get; set; }
        public DbSet<Mufredat> Mufredatlar { get; set; }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }
        public DbSet<SinifListe> SinifListeleri { get; set; }
        public DbSet<Unvan> Unvanlar { get; set; }
        public DbSet<Donem> Donemler { get; set; }
        public DbSet<SinavTur> SinavTurleri { get; set; }
        public DbSet<Sube> Subeler { get; set; }
        public DbSet<DersKayit> DersKayitlar { get; set; }
    }
}
