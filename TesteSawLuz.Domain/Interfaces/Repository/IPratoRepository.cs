using System;
using System.Collections.Generic;
using System.Text;
using TesteSawLuz.Domain.Entities;

namespace TesteSawLuz.Domain.Interfaces.Repository
{
    public interface IPratoRepository
    {
        IEnumerable<Prato> Listar();
        bool CadastrarPratos(Prato model);
        bool EditarPratos(Prato model);
        bool ExcluirPratos(Prato model);
        Prato ObterPorId(int id);

    }
}
