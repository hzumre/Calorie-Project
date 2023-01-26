using KaloriHesaplamaProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Mapping
{
    public class TuketimMapping:BaseEntityMapping<Tuketim>
    {
        public override void Configure(EntityTypeBuilder<Tuketim> tuketim)
        {
            tuketim.HasKey(x => x.ID);
            tuketim.Property(x => x.Adet).IsRequired();
            tuketim.Property(x=>x.TuketimTarihi).IsRequired();
           
            tuketim.Property(x => x.Ogun).IsRequired();
            tuketim.HasOne(x => x.Kullanici).WithMany(x => x.Tuketimler).HasForeignKey(x => x.KullaniciID);
           
          

            base.Configure(tuketim);
        }
    }
}
