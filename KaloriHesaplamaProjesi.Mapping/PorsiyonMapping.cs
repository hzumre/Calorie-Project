using KaloriHesaplamaProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Mapping
{
    public class PorsiyonMapping:BaseEntityMapping<Porsiyon>
    {
        public override void Configure(EntityTypeBuilder<Porsiyon> porsiyon)
        {
            porsiyon.HasKey(x => x.ID);
            porsiyon.Property(x => x.PorsiyonAd).HasMaxLength(50).HasAnnotation("TypeName","vchar").IsRequired();
            porsiyon.HasMany(x => x.BesinPorsiyonlari).WithOne(x => x.Porsiyon).HasForeignKey(x => x.PorsiyonID);
            base.Configure(porsiyon);
        }
    }
}
