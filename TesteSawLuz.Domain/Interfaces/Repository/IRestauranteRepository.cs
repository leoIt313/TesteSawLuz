using System;
using System.Collections.Generic;
using System.Text;
using TesteSawLuz.Domain.Entities;

namespace TesteSawLuz.Domain.Interfaces.Repository
{
    public interface IRestauranteRepository
    {
        bool CadastrarRestaurante(Restaurante model);
        IEnumerable<Restaurante> Listar(string nomeRestaurante);
        bool EditarRestaurante(Restaurante model);
        bool ExcluirRestaurante(Restaurante model);
        Restaurante ObterPorId(int id);
    }
}
