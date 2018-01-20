using System;
using System.Collections.Generic;
using System.Text;
using TesteSawLuz.Application.ViewModel.Request;
using TesteSawLuz.Application.ViewModel.Response;

namespace TesteSawLuz.Application.Interfaces
{
    public interface IRestauranteApplication
    {
        bool CadastrarRestaurante(CadastrarEditarRestauranteRequestViewModel model);
        IEnumerable<ListarRestauranteResponseViewModel> Listar(string nomeRestaurante);
        bool EditarRestaurante(CadastrarEditarRestauranteRequestViewModel model);
        bool ExcluirRestaurante(int id);
    }
}
