using System;
using System.Collections.Generic;
using System.Text;

namespace TesteSawLuz.Domain.Entities
{
    public class Prato
    {
        public int IdPrato { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int IdRestaurante { get; set; } 
        public bool Status { get; set; }
        public virtual Restaurante Restaurante { get; set; }
    }
}
