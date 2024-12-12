using Project.CONF.Options;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new YazarConfiguration());
            modelBuilder.Configurations.Add(new OdaConfiguration());
            modelBuilder.Configurations.Add(new KitapConfiguration());
            modelBuilder.Configurations.Add(new RafConfiguration());
            modelBuilder.Configurations.Add(new KategoriConfiguration());
            modelBuilder.Configurations.Add(new EtiketConfiguration());
            modelBuilder.Configurations.Add(new KitapEtiketConfiguration());
        }

        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Oda> Odalar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Raf> Raflar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Etiket> Etiketler { get; set; }
        public DbSet<KitapEtiket> KitapEtiketleri { get; set; }

    }
}
