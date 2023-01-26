using KaloriHesaplamaProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Mapping
{
    public class BesinTurMapping:BaseEntityMapping<BesinTur>
    {
        public override void Configure(EntityTypeBuilder<BesinTur> besintur)
        {
            besintur.HasKey(x => x.ID);
            besintur.Property(x => x.Ad).HasMaxLength(100).HasAnnotation("Type", "varchar").IsRequired();
            

            base.Configure(besintur);
        }
    }
}
