using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TesteSawLuz.Domain.Entities;
using TesteSawLuz.Domain.Interfaces.Repository;
using TesteSawLuz.Infra.Context;

namespace TesteSawLuz.Infra.Repository
{
    public class PratoRepository : Repository<Prato>, IPratoRepository
    {
        public PratoRepository(TesteSawLuzContext context) : base(context)
        { }

        public IEnumerable<Prato> Listar()
        {
            return this.GetAll().Include(x => x.Restaurante).Where(x => x.Status);
        }

        public bool CadastrarPratos(Prato model)
        {
            this.Add(model);
            return this.SaveChanges() > 0;
        }

        public bool EditarPratos(Prato model)
        {
            this.Update(model);
            return this.SaveChanges() > 0;
        }

        public bool ExcluirPratos(Prato model)
        {
            this.Update(model);
            return this.SaveChanges() > 0;
        }

        public Prato ObterPorId(int id)
        {
            return this.GetAll().Include(x => x.Restaurante).First(x => x.IdPrato == id);
        }
    }
}
