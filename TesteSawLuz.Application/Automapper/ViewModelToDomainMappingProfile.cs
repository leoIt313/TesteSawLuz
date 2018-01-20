using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TesteSawLuz.Application.ViewModel.Request;
using TesteSawLuz.Domain.Entities;

namespace TesteSawLuz.Application.Automapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            Configure();
        }

        protected void Configure()
        {
            CreateMap<CadastrarEditarPratosResquestViewModel, Prato>().ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.Valor))
                                                                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.NomePrato))
                                                                .ForMember(dest => dest.IdRestaurante, opt => opt.MapFrom(src => src.IdRestaurante));


            CreateMap<CadastrarEditarPratosResquestViewModel, Prato>().ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.Valor))
                .ForMember(dest => dest.IdPrato, opt => opt.MapFrom(src => src.IdPrato))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.NomePrato))
                .ForMember(dest => dest.IdRestaurante, opt => opt.MapFrom(src => src.IdRestaurante));


            CreateMap<CadastrarEditarRestauranteRequestViewModel, Restaurante>().ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.NomeRestaurante));

            CreateMap<CadastrarEditarRestauranteRequestViewModel, Restaurante>().ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.NomeRestaurante))
                .ForMember(dest => dest.IdRestaurante, opt => opt.MapFrom(src => src.IdRestaurante));

        }
    }
}
