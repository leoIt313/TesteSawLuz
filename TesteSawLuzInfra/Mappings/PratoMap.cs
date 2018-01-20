using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteSawLuz.Domain.Entities;
using TesteSawLuz.Infra.Context;

namespace TesteSawLuz.Infra.Mappings
{
    public class PratoMap : IEntityTypeConfiguration<Prato>
    {
        public void Configure(EntityTypeBuilder<Prato> builder)
        {
            builder.ToTable("Prato", "dbo");
            builder.HasKey(x => x.IdPrato);
            builder.Property(x => x.IdPrato).HasColumnName(@"IdPrato").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar(150)").IsRequired().HasMaxLength(150);
            builder.Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("decimal").IsRequired().HasPrecision(18, 0);
            builder.Property(x => x.IdRestaurante).HasColumnName(@"IdRestaurante").HasColumnType("int").IsRequired();
            builder.Property(x => x.Status).HasColumnName(@"Status").HasColumnType("bit").IsRequired();

            builder.HasOne(a => a.Restaurante).WithMany(b => b.Pratos).HasForeignKey(c => c.IdRestaurante);
        }
    }
}
