using System;
using System.Collections.Generic;
using System.Text;
using TesteSawLuz.Domain.Entities;
using TesteSawLuz.Domain.Interfaces.Repository;
using TesteSawLuz.Domain.Interfaces.Services;

namespace TesteSawLuz.Domain.Services
{
    public class PratoDomain : IPratoDomain
    {
        private readonly IPratoRepository _pratoRepository;
        private readonly IRestauranteRepository _restauranteRepository;
        public PratoDomain(IPratoRepository pratoRepository, IRestauranteRepository restauranteRepository)
        {
            _pratoRepository = pratoRepository;
            _restauranteRepository = restauranteRepository;
        }

        public IEnumerable<Prato> Listar()
        {
            return _pratoRepository.Listar();
        }

        public bool CadastrarPratos(Prato model)
        {
            model.Status = true;
            return _pratoRepository.CadastrarPratos(model);
        }

        public bool EditarPratos(Prato model)
        {
            var pratoDb = _pratoRepository.ObterPorId(model.IdPrato);

            pratoDb.Nome = model.Nome;
            pratoDb.Valor = model.Valor;

            return _pratoRepository.EditarPratos(pratoDb);
        }

        public bool ExcluirPratos(int id)
        {
            var pratoDb = _pratoRepository.ObterPorId(id);
            pratoDb.Status = false;
            return _pratoRepository.ExcluirPratos(pratoDb);
        }
    }
}
