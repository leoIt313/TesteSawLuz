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
    public class RestauranteRepository : Repository<Restaurante>, IRestauranteRepository
    {
        public RestauranteRepository(TesteSawLuzContext context) : base(context)
        {
        }

        public bool CadastrarRestaurante(Restaurante model)
        {
            this.Add(model);
            return this.SaveChanges() > 0;
        }

        public IEnumerable<Restaurante> Listar(string nomeRestaurante)
        {
            return this.GetAll().Where(x => x.Nome.Contains(nomeRestaurante) && x.Status == true).OrderBy(x=>x.Nome);
        }

        public bool EditarRestaurante(Restaurante model)
        {
            this.Update(model);
            return this.SaveChanges() > 0;
        }

        public bool ExcluirRestaurante(Restaurante model)
        {
            this.Update(model);
            return this.SaveChanges() > 0;
        }

        public Restaurante ObterPorId(int id)
        {
            return this.GetAll().First(x => x.IdRestaurante == id);
        }
    }
}
