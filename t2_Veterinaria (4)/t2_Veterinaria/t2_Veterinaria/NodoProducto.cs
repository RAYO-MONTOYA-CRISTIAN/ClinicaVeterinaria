using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class NodoProducto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Especificaciones { get; set; }
        public string Tipo { get; set; } 
    }
}
