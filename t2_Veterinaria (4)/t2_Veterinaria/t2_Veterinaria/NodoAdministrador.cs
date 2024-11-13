using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class NodoAdministrador
    {
        public string NombreMascota { get; set; }
        public string Raza { get; set; }
        public string Dueño { get; set; }
        public string Genero { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string HoraIngreso { get; set; }
        public string CodigoAdministrador { get; set; } 
        public NodoAdministrador Sgte { get; set; }

        public NodoAdministrador(string nombreMascota, string raza, string dueño, string genero, DateTime fechaIngreso, string horaIngreso, string codigoAdministrador)
        {
            NombreMascota = nombreMascota;
            Raza = raza;
            Dueño = dueño;
            Genero = genero;
            FechaIngreso = fechaIngreso;
            HoraIngreso = horaIngreso;
            CodigoAdministrador = codigoAdministrador;
            Sgte = null;
        }
    }
}
