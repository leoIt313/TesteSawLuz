using System;
using System.Collections.Generic;
using System.Text;

namespace TesteSawLuz.Domain.Entities
{
    public class Restaurante
    {
        public int IdRestaurante { get; set; } 
        public string Nome { get; set; }
        public bool Status { get; set; } 

        public virtual System.Collections.Generic.ICollection<Prato> Pratos { get; set; } 

        public Restaurante()
        {
            Pratos = new List<Prato>();
        }
    }

}
