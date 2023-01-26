using KaloriHesaplamaProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Mapping
{
    public class KullaniciMapping:BaseEntityMapping<Kullanici>
    {
        public override void Configure(EntityTypeBuilder<Kullanici> kullanici)
        {
            kullanici.HasKey(x => x.ID);
            kullanici.Property(x => x.AdSoyad).HasMaxLength(150).IsRequired();
            kullanici.Property(x => x.Mail).HasMaxLength(150).HasAnnotation("TypeName", "varchar").IsUnicode(true).IsRequired();
            kullanici.Property(x=>x.Sifre).HasMaxLength(150).HasAnnotation("TypeName", "varchar").IsRequired();
            kullanici.Property(x => x.Cinsiyet).IsRequired();
            kullanici.Property(x => x.Boy).HasAnnotation("TypeName", "int").IsRequired();
            kullanici.Property(x=>x.Kilo).HasAnnotation("TypeName", "int").IsRequired();
            kullanici.Property(x=>x.Yas).HasAnnotation("TypeName", "int").IsRequired();



            base.Configure(kullanici);
        }
    }
}
