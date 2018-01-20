using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using TesteSawLuz.Application.ViewModel.Response;
using TesteSawLuz.Domain.Entities;

namespace TesteSawLuz.Application.Automapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            Configure();
        }

        protected void Configure()
        {
            CreateMap<Restaurante, ListarRestauranteResponseViewModel>().ForMember(dest => dest.IdRestaurante, opt => opt.MapFrom(src => src.IdRestaurante)).ForMember(dest => dest.NomeRestaurante, opt => opt.MapFrom(src => src.Nome));

            CreateMap<Prato, ListarPratoResponseViewModel>().ForMember(dest => dest.IdRestaurante,
                    opt => opt.MapFrom(src => src.Restaurante.IdRestaurante))
                .ForMember(dest => dest.NomeRestaurante, opt => opt.MapFrom(src => src.Restaurante.Nome))
                .ForMember(dest => dest.IdPrato, opt => opt.MapFrom(src => src.IdPrato))
                .ForMember(dest => dest.NomePrato, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.Valor));




        }
    }
}
