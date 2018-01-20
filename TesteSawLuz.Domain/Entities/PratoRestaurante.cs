using System;
using System.Collections.Generic;
using System.Text;

namespace TesteSawLuz.Domain.Entities
{
    public class PratoRestaurante
    {
        public int IdPratoRestaurante { get; set; } 
        public int IdPrato { get; set; } 
        public int IdRestaurante { get; set; } 

        public virtual Prato Prato { get; set; } 

        public virtual Restaurante Restaurante { get; set; } 
    }
}
