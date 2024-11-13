using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class ConsultasAleatoriamente
    {
        private static Random random = new Random();
        private static string[] nombresClientes = { "Carlos", "María", "Luis", "Ana", "Pedro", "Lucía", "Javier", "Sofía", "Miguel", "Carmen" };
        private static string[] nombresMascotas = { "Firulais", "Max", "Luna", "Coco", "Toby", "Nina", "Rocky", "Bella", "Chispa", "Simba" };
        private static string[] razas = { "Labrador", "Poodle", "Bulldog", "Beagle", "Chihuahua", "Pastor Alemán", "Golden Retriever" };
        private static string[] tiposConsultas = { "Consulta General", "Vacunación", "Chequeo" };

        public static NodoConsulta GenerarConsultaAleatoria()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string nombreCliente = nombresClientes[random.Next(nombresClientes.Length)];
            string nombreMascota = nombresMascotas[random.Next(nombresMascotas.Length)];
            string razaMascota = razas[random.Next(razas.Length)];
            string tipoConsulta = tiposConsultas[random.Next(tiposConsultas.Length)];

            DateTime fechaHoraConsulta = DateTime.Now.AddDays(random.Next(30)).AddHours(random.Next(24)).AddMinutes(random.Next(60));

            return new NodoConsulta(nombreCliente, nombreMascota, razaMascota, fechaHoraConsulta, tipoConsulta);
        }

        public static void GenerarConsultasAleatorias(ListasConsultas listaConsultas, int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < cantidad; i++)
            {
                NodoConsulta consultaAleatoria = GenerarConsultaAleatoria();
                listaConsultas.AgregarConsulta(consultaAleatoria);
            }
        }
    }
}
