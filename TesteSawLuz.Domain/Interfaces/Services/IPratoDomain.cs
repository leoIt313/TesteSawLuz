using System;
using System.Collections.Generic;
using System.Text;
using TesteSawLuz.Domain.Entities;

namespace TesteSawLuz.Domain.Interfaces.Services
{
    public interface IPratoDomain
    {
        IEnumerable<Prato> Listar();
        bool CadastrarPratos(Prato model);
        bool EditarPratos(Prato model);
        bool ExcluirPratos(int id);
    }
}
