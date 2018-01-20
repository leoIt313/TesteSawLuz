

using System.Collections.Generic;
using AutoMapper;
using TesteSawLuz.Application.Interfaces;
using TesteSawLuz.Application.ViewModel.Request;
using TesteSawLuz.Application.ViewModel.Response;
using TesteSawLuz.Domain.Entities;
using TesteSawLuz.Domain.Interfaces.Services;

namespace TesteSawLuz.Application.Services
{
    public class RestauranteApplication: IRestauranteApplication
    {
        private readonly IRestauranteDomain _restauranteService;
        public RestauranteApplication(IRestauranteDomain restauranteService)
        {
            _restauranteService = restauranteService;
        }

        public bool CadastrarRestaurante(CadastrarEditarRestauranteRequestViewModel model)
        {
            return _restauranteService.CadastrarRestaurante(Mapper.Map<CadastrarEditarRestauranteRequestViewModel, Restaurante>(model));
        }

        public IEnumerable<ListarRestauranteResponseViewModel> Listar(string nomeRestaurante)
        {
            return Mapper.Map<IEnumerable<Restaurante>, List<ListarRestauranteResponseViewModel>>(_restauranteService.Listar(nomeRestaurante));
        }

        public bool EditarRestaurante(CadastrarEditarRestauranteRequestViewModel model)
        {
            return _restauranteService.EditarRestaurante(Mapper.Map<CadastrarEditarRestauranteRequestViewModel, Restaurante>(model));
        }

        public bool ExcluirRestaurante(int id)
        {
            return _restauranteService.ExcluirRestaurante(id);
        }
    }
}
