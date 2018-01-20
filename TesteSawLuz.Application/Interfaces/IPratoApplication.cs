using System;
using System.Collections.Generic;
using System.Text;
using TesteSawLuz.Application.ViewModel.Request;
using TesteSawLuz.Application.ViewModel.Response;

namespace TesteSawLuz.Application.Interfaces
{
    public interface IPratoApplication
    {
        IEnumerable<ListarPratoResponseViewModel> Listar();
        bool CadastrarPratos(CadastrarEditarPratosResquestViewModel model);
        bool EditarPratos(CadastrarEditarPratosResquestViewModel model);
        bool ExcluirPratos(int id);

    }
}
