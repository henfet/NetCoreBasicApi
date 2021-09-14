using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreBase.Features.Inventory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.DataContext.Maps
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items", "dbo");
            
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).IsRequired().UseIdentityColumn();

            builder.Property(t => t.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
            builder.Property(t => t.Quantity).HasColumnName("Quantity").IsRequired();
            builder.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
       