using KaloriHesaplamaProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Mapping
{
    public class BesinPorsiyonuMapping:BaseEntityMapping<BesinPorsiyonu>
    {
        public override void Configure(EntityTypeBuilder<BesinPorsiyonu> besinporsiyonu)
        {
            besinporsiyonu.HasKey(x => x.ID);
            besinporsiyonu.Property(x => x.Kalori).IsRequired();

            besinporsiyonu.HasOne(x => x.Besin).WithMany(x => x.BesinPorsiyonlari).HasForeignKey(x => x.BesinID);
            besinporsiyonu.HasOne(x => x.Porsiyon).WithMany(x => x.BesinPorsiyonlari).HasForeignKey(x => x.PorsiyonID);
            besinporsiyonu.HasMany(x => x.Tuketimler).WithOne(x => x.BesinPorsiyonu).HasForeignKey(x => x.BesinPorsiyonID);
            base.Configure(besinporsiyonu);
        }
    }
}
