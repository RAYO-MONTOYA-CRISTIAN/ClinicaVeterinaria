using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class NodoCliente
    {
        public string NombreMascota;
        public string Raza;
        public string Dueño;
        public string Genero;
        public DateTime FechaIngreso;
        public string HoraIngreso;
        public string CodigoCliente;
        public NodoCliente Sgte;

        public NodoCliente(string nombreMascota, string raza, string dueño, string genero, DateTime fechaIngreso, string horaIngreso, string codigoCliente)
        {
            NombreMascota = nombreMascota;
            Raza = raza;
            Dueño = dueño;
            Genero = genero;
            FechaIngreso = fechaIngreso;
            HoraIngreso = horaIngreso;
            CodigoCliente = codigoCliente;
            Sgte = null;
        }

    }
}
