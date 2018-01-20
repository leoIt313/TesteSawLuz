using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteSawLuz.Domain.Entities;

namespace TesteSawLuz.Infra.Mappings
{
    public class PratoRestauranteMap : IEntityTypeConfiguration<PratoRestaurante>
    {
        public void Configure(EntityTypeBuilder<PratoRestaurante> builder)
        {
            //builder.ToTable("PratoRestaurante", "dbo");
            //builder.HasKey(x => x.IdPratoRestaurante);
            //builder.Property(x => x.IdPratoRestaurante).HasColumnName(@"IdPratoRestaurante").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            //builder.Property(x => x.IdPrato).HasColumnName(@"IdPrato").HasColumnType("int").IsRequired();
            //builder.Property(x => x.IdRestaurante).HasColumnName(@"IdRestaurante").HasColumnType("int").IsRequired();
            //builder.HasOne(a => a.Prato).WithMany(b => b.PratoRestaurantes).HasForeignKey(c => c.IdPrato); 
            //builder.HasOne(a => a.Restaurante).WithMany(b => b.PratoRestaurantes).HasForeignKey(c => c.IdRestaurante);
        }
    }
}
