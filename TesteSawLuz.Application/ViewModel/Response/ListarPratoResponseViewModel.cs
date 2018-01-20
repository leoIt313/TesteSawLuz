using System;
using System.Collections.Generic;
using System.Text;

namespace TesteSawLuz.Application.ViewModel.Response
{
    public class ListarPratoResponseViewModel
    {
        public int IdRestaurante { get; set; }
        public string NomeRestaurante { get; set; }
        public int IdPrato { get; set; }
        public string NomePrato { get; set; }
        public decimal Valor { get; set; }
    }

}
