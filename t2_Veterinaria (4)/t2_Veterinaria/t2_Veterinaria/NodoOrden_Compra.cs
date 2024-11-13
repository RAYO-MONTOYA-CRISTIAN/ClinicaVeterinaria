using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class NodoOrden_Compra
    {
        public int Id { get; set; }
        public DateTime FechaOrden { get; set; }
        public List<NodoProducto> ProductosSolicitados { get; set; }
    }
}
