using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class NodoMedicamento : NodoProducto
    {
        public string Dosis { get; set; }
        public string PrincipioActivo { get; set; }
    }
}
