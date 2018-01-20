using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteSawLuz.Domain.Entities;

namespace TesteSawLuz.Infra.Mappings
{
    public class RestauranteMap : IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.ToTable("Restaurante", "dbo");
            builder.HasKey(x => x.IdRestaurante);

            builder.Property(x => x.IdRestaurante).HasColumnName(@"IdRestaurante").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar(150)").IsRequired().IsUnicode(false).HasMaxLength(150);
            builder.Property(x => x.Status).HasColumnName(@"Status").HasColumnType("bit").IsRequired();

           
        }
    }
  
}
