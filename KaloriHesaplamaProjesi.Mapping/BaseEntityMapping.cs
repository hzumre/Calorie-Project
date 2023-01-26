using KaloriHesaplamaProjesi.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Mapping
{
    public abstract class BaseEntityMapping<T>: IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> baseEntity)
        {
            
            baseEntity.Property(x => x.CreatedDate).IsRequired();
            baseEntity.Property(x => x.CreatedBy).HasMaxLength(128).IsRequired(false);
            baseEntity.Property(x => x.ModifiedDate).IsRequired();
            baseEntity.Property(x => x.ModifiedBy).HasMaxLength(128).IsRequired(false);
        }
    }
}
