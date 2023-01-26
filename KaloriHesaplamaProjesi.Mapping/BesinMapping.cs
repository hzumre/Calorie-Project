using KaloriHesaplamaProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Mapping
{
    public class BesinMapping:BaseEntityMapping<Besin>
    {
        public override void Configure(EntityTypeBuilder<Besin> besin)
        {
            besin.HasKey(x => x.ID);
            besin.Property(x => x.BesinAd).HasMaxLength(100).HasAnnotation("Typname", "varchar").IsRequired();
            besin.Property(x => x.BesinTurID).IsRequired();


            besin.HasOne(x => x.BesinTur).WithMany(x => x.Besinler).HasForeignKey(x => x.BesinTurID);
            base.Configure(besin);
        }
    }
}
