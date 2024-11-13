using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class NodoConsulta
    {
        public string NombreCliente { get; set; }
        public string NombreMascota { get; set; }
        public string RazaMascota { get; set; }
        public DateTime FechaHoraConsulta { get; set; }
        public string TipoConsulta { get; set; }
        public NodoConsulta Anterior { get; set; }
        public NodoConsulta Siguiente { get; set; }

        public NodoConsulta(string nombreCliente, string nombreMascota, string razaMascota, DateTime fechaHoraConsulta, string tipoConsulta)
        {
            NombreCliente = nombreCliente;
            NombreMascota = nombreMascota;
            RazaMascota = razaMascota;
            FechaHoraConsulta = fechaHoraConsulta;
            TipoConsulta = tipoConsulta;
            Anterior = null;
            Siguiente = null;
        }
    }
}
