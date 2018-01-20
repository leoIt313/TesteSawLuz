using System;
using System.Collections.Generic;
using System.Text;
using TesteSawLuz.Domain.Entities;

namespace TesteSawLuz.Domain.Interfaces.Services
{
    public interface IRestauranteDomain
    {
        bool CadastrarRestaurante(Restaurante model);
        IEnumerable<Restaurante> Listar(string nomeRestaurante);
        bool EditarRestaurante(Restaurante model);
        bool ExcluirRestaurante(int id);
    }
}
