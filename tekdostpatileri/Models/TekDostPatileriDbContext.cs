using Microsoft.EntityFrameworkCore;

namespace tekdostpatileri.Models
{
    public class TekDostPatileriDbContext:DbContext
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=Huawei\\OGUZHAN;Initial Catalog=SqlTekDostPatileriDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //optionsBuilder.UseSqlServer("Data Source=94.73.144.21;Initial Catalog=u9544174_pati; User Id=u9544174_pati;Password=4QF4su-_tfD=:92Q;");
            }

           public DbSet<Anasayfa> anasayfas{ get; set; }
           public DbSet<Logo> logos { get; set; }
           public DbSet<Hakkında> hakkındas { get; set; }
		   public DbSet<Hizmetler> hizmetlers { get; set; }
		   public DbSet<İletişim> iletişims { get; set; }
           public DbSet<Mail> mails { get; set; }
		   public DbSet<Cevap> cevaps { get; set; }
           public DbSet<Ödeme> ödemes { get; set; }
           public DbSet<Galeri> galeris { get; set; }
           public DbSet<Yuvamız> yuvamızs { get; set; }
           public DbSet<Giriş> girişs { get; set; }
    }
}
