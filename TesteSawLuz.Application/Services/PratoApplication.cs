using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TesteSawLuz.Application.Interfaces;
using TesteSawLuz.Application.ViewModel.Request;
using TesteSawLuz.Application.ViewModel.Response;
using TesteSawLuz.Domain.Entities;
using TesteSawLuz.Domain.Interfaces.Services;

namespace TesteSawLuz.Application.Services
{
    public class PratoApplication: IPratoApplication
    {
        private readonly IPratoDomain _pratoService;

        public PratoApplication(IPratoDomain pratoService)
        {
            _pratoService = pratoService;
        }
        public IEnumerable<ListarPratoResponseViewModel> Listar()
        {
            return Mapper.Map<IEnumerable<Prato>, List<ListarPratoResponseViewModel>>(_pratoService.Listar());
        }

        public bool CadastrarPratos(CadastrarEditarPratosResquestViewModel model)
        {
           return _pratoService.CadastrarPratos(Mapper.Map<CadastrarEditarPratosResquestViewModel, Prato>(model));
        }

        public bool EditarPratos(CadastrarEditarPratosResquestViewModel model)
        {
            return _pratoService.EditarPratos(Mapper.Map<CadastrarEditarPratosResquestViewModel, Prato>(model));
        }

        public bool ExcluirPratos(int id)
        {
            return _pratoService.ExcluirPratos(id);
        }
    }
}
