﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using TesteSawLuz.Domain.Entities;
using TesteSawLuz.Infra.Mappings;

namespace TesteSawLuz.Infra.Context
{
    public class TesteSawLuzContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region modelBuilder

            modelBuilder.ApplyConfiguration(new PratoMap());
            modelBuilder.ApplyConfiguration(new RestauranteMap());
          
            #endregion


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        public void EnsureSeedData(TesteSawLuzContext context)
        {
            //TipoPessoa fisica = new TipoPessoa
            //{
            //    IdTipo = 1,
            //    Descricao = "Pessoa Fisica"
            //};

            //TipoPessoa juridica = new TipoPessoa
            //{
            //    IdTipo = 2,
            //    Descricao = "Pessoa Juridica"
            //};

            //var listTipos = new List<TipoPessoa> { fisica, juridica };

            //if ((!context.Set<TipoPessoa>().Any()) || (context.Set<TipoPessoa>().Any(x => !listTipos.Any(y => y.IdTipo == x.IdTipo))))
            //{
            //    context.AddRange(listTipos);
            //    context.SaveChanges();
            //}
        }
    }

    public static class SqlServerModelBuilderExtensions
    {
        public static PropertyBuilder<decimal?> HasPrecision(this PropertyBuilder<decimal?> builder, int precision,
            int scale)
        {
            return builder.HasColumnType($"decimal({precision},{scale})");
        }

        public static PropertyBuilder<decimal> HasPrecision(this PropertyBuilder<decimal> builder, int precision,
            int scale)
        {
            return builder.HasColumnType($"decimal({precision},{scale})");
        }
    }
}
