using System;
using System.Collections.Generic;
using System.Text;
using TesteSawLuz.Domain.Entities;
using TesteSawLuz.Domain.Interfaces.Repository;
using TesteSawLuz.Domain.Interfaces.Services;

namespace TesteSawLuz.Domain.Services
{
    public class RestauranteDomain: IRestauranteDomain
    {
        private readonly IRestauranteRepository _restauranteRepository;

        public RestauranteDomain(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        public bool CadastrarRestaurante(Restaurante model)
        {
            model.Status = true;
            return _restauranteRepository.CadastrarRestaurante(model);
        }

        public IEnumerable<Restaurante> Listar(string nomeRestaurante)
        {
            return _restauranteRepository.Listar(string.IsNullOrEmpty(nomeRestaurante) ? string.Empty: nomeRestaurante);
        }

        public bool EditarRestaurante(Restaurante model)
        {
            var rest=_restauranteRepository.ObterPorId(model.IdRestaurante);
            rest.Nome = model.Nome;

            return _restauranteRepository.EditarRestaurante(rest);
        }

        public bool ExcluirRestaurante(int id)
        {
            var rest = _restauranteRepository.ObterPorId(id);
            rest.Status = false;
            return _restauranteRepository.ExcluirRestaurante(rest);
        }
    }
}
