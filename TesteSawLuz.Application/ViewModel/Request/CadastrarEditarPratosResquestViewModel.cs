using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TesteSawLuz.Application.ViewModel.Request
{
    public class CadastrarEditarPratosResquestViewModel
    {
        public int IdPrato { get; set; }
        public int IdRestaurante { get; set; }
        public string NomePrato { get; set; }
        public decimal Valor { get; set; }

        public List<ItemRestauranteViewModel> ItemLancheViewModel { get; set; }
        public IEnumerable<SelectListItem> SelectItemRestaurante
        {
            get { return ItemLancheViewModel == null ? null : ItemLancheViewModel.Select(a => new SelectListItem() { Text = a.NomeRestaurante, Value = a.IdRestaurante.ToString() }).OrderBy(x => x.Text).ToList(); }
        }

    }

    public class ItemRestauranteViewModel
    {
        public int IdRestaurante { get; set; }
        public string NomeRestaurante { get; set; }
    }
}
