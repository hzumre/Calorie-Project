using KaloriHesaplamaProjesi.Entities.Concrete;
using KaloriHesaplamaProjesi.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.DAL
{
    public class KaloriHesaplamaProjesiContext:DbContext
    {
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<BesinPorsiyonu> BesinPorsiyonlari { get; set; }
        public DbSet<BesinTur> BesinTurleri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<Tuketim> Tuketimler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=.;database=KaloriHesaplamaProjesiDb;uid=sa;pwd=123");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BesinMapping());
            modelBuilder.ApplyConfiguration(new BesinPorsiyonuMapping());
            modelBuilder.ApplyConfiguration(new BesinTurMapping());
            modelBuilder.ApplyConfiguration(new KullaniciMapping());
            modelBuilder.ApplyConfiguration(new PorsiyonMapping());
            modelBuilder.ApplyConfiguration(new TuketimMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
