//using TesteSion.Infra.UoW;

using System.Net.Mime;
using AutoMapper;
using TesteSawLuz.Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Configuration;
using TesteSawLuz.Application.Interfaces;
using TesteSawLuz.Application.Services;
using TesteSawLuz.Domain.Interfaces.Repository;
using TesteSawLuz.Domain.Interfaces.Services;
using TesteSawLuz.Domain.Services;
using TesteSawLuz.Infra.Repository;

namespace TesteSawLuz.CrossCutting.IoC
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region Application

            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));

            services.AddScoped<IRestauranteApplication, RestauranteApplication>();
            services.AddScoped<IPratoApplication, PratoApplication>();

            #endregion

            #region Domain

            services.AddScoped<IPratoDomain, PratoDomain>();
            services.AddScoped<IRestauranteDomain, RestauranteDomain>();

            services.AddScoped<IPratoRepository, PratoRepository>();
            services.AddScoped<IRestauranteRepository, RestauranteRepository>();

            #endregion

            #region  Infra

            services.AddScoped<TesteSawLuzContext>();

            #endregion

        }
    }
}
