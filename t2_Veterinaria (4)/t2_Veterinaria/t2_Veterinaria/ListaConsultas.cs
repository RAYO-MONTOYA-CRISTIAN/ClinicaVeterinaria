using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class ListasConsultas
    {
        
        private NodoConsulta cabeza;
        private NodoConsulta cola;

        public ListasConsultas()
        {
            cabeza = null;
            cola = null;
        }

        public void AgregarConsulta(NodoConsulta nuevaConsulta)
        {
            if (cabeza == null)
            {
                cabeza = nuevaConsulta;
                cola = nuevaConsulta;
            }
            else
            {
                cola.Siguiente = nuevaConsulta;
                nuevaConsulta.Anterior = cola;
                cola = nuevaConsulta;
            }
        }

        public bool EliminarConsulta(string nombreClienteOMascota)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            NodoConsulta actual = cabeza;
            while (actual != null)
            {
                if (actual.NombreCliente.Equals(nombreClienteOMascota, StringComparison.OrdinalIgnoreCase) ||
                    actual.NombreMascota.Equals(nombreClienteOMascota, StringComparison.OrdinalIgnoreCase))
                {
                    if (actual == cabeza)
                    {
                        cabeza = actual.Siguiente;
                        if (cabeza != null) cabeza.Anterior = null;
                    }
                    else if (actual == cola)
                    {
                        cola = actual.Anterior;
                        if (cola != null) cola.Siguiente = null;
                    }
                    else
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior = actual.Anterior;
                    }
                    Console.WriteLine("Consulta eliminada exitosamente.");
                    return true;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("No se encontró ninguna consulta con ese nombre.");
            return false;
        }

        public NodoConsulta BuscarConsulta(string nombreClienteOMascota)
        {
            NodoConsulta actual = cabeza;
            while (actual != null)
            {
                if (actual.NombreCliente.Equals(nombreClienteOMascota, StringComparison.OrdinalIgnoreCase) ||
                    actual.NombreMascota.Equals(nombreClienteOMascota, StringComparison.OrdinalIgnoreCase))
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public void MostrarConsultas()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            NodoConsulta actual = cabeza;
            

            Console.WriteLine("----------------------------------------------+---------------------------------------------+------------------");
            Console.WriteLine($"{"Cliente",-15} | {"Mascota",-15} | {"Fecha y Hora",-24} | {"Tipo de Consulta",-15}");
            Console.WriteLine("----------------------------------------------+---------------------------------------------+------------------");

            while (actual != null)
            {
                Console.WriteLine($"{actual.NombreCliente,-15} | {actual.NombreMascota,-15} | {actual.FechaHoraConsulta,-20} | {actual.TipoConsulta,-15}");
                actual = actual.Siguiente;
            }

            Console.WriteLine("----------------------------------------------+---------------------------------------------+------------------");
        }

        public void AgregarConsultaCliente()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Ingrese el nombre del cliente: ");
            string nombreCliente = Console.ReadLine();

            Console.Write("Ingrese el nombre de la mascota: ");
            string nombreMascota = Console.ReadLine();

            Console.Write("Ingrese la raza de la mascota: ");
            string razaMascota = Console.ReadLine();

            Console.Write("Ingrese el tipo de consulta: ");
            string tipoConsulta = Console.ReadLine();

            Console.Write("Ingrese la fecha y hora de la consulta (ej: 2024-10-20 15:00): ");
            DateTime fechaHora = DateTime.Parse(Console.ReadLine());

            NodoConsulta nuevaConsulta = new NodoConsulta(nombreCliente, nombreMascota, razaMascota, fechaHora, tipoConsulta);
            AgregarConsulta(nuevaConsulta);

            Console.WriteLine("Consulta agregada exitosamente.");

            Console.WriteLine("¿Desea ver sus consultas? (si/no)");
            if (Console.ReadLine().ToLower() == "s")
            {
                MostrarConsultas();
            }
        }

        public void CancelarConsultaCliente(string nombreClienteOMascota)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (EliminarConsulta(nombreClienteOMascota))
            {
                Console.WriteLine("Consulta cancelada exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró ninguna consulta con ese nombre.");
            }
        }

    }
}
