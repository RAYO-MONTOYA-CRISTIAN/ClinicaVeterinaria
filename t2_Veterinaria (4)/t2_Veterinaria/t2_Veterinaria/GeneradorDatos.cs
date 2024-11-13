using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class GeneradorDatos
    {
        private static Random random = new Random();

        private static List<string> nombresMascotas = new List<string> { "Rex", "Fido", "Luna", "Bella", "Max", "Scott" };
        private static List<string> razas = new List<string> { "Labrador", "Beagle", "Poodle", "Bulldog", "Pastor Alemán", "Doberman"};
        private static List<string> dueños = new List<string> { "Juan", "María", "Pedro", "Ana", "Luis", "Alex" };

        public static void GenerarDatosAdministrador(Veterinaria veterinaria)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 5; i++) 
            {
                string nombreMascota = nombresMascotas[random.Next(nombresMascotas.Count)];
                string raza = razas[random.Next(razas.Count)];
                string dueño = dueños[random.Next(dueños.Count)];
                string genero = random.Next(0, 2) == 0 ? "Macho" : "Hembra";
                DateTime fechaIngreso = DateTime.Now.AddDays(-random.Next(0, 30));
                int hora = random.Next(0, 24); 
                int minuto = random.Next(0, 60); 
                string horaIngreso = new DateTime(fechaIngreso.Year, fechaIngreso.Month, fechaIngreso.Day, hora, minuto, 0).ToString("HH:mm");

                string codigoCliente = GenerarCodigoCliente();

                veterinaria.AgregarMascotaAdmin(nombreMascota, raza, dueño, genero, fechaIngreso, horaIngreso, codigoCliente);
            }
            Console.WriteLine("Datos aleatorios para Administrador generados exitosamente.");
        }

        public static void GenerarDatosTrabajador(Veterinaria veterinaria)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 5; i++) 
            {
                string nombreMascota = nombresMascotas[random.Next(nombresMascotas.Count)];
                string raza = razas[random.Next(razas.Count)];
                string dueño = dueños[random.Next(dueños.Count)];
                string genero = random.Next(0, 2) == 0 ? "Macho" : "Hembra";
                DateTime fechaIngreso = DateTime.Now.AddDays(-random.Next(0, 30));
                int hora = random.Next(0, 24);
                int minuto = random.Next(0, 60);
                string horaIngreso = new DateTime(fechaIngreso.Year, fechaIngreso.Month, fechaIngreso.Day, hora, minuto, 0).ToString("HH:mm");

                string codigoCliente = GenerarCodigoCliente();

                veterinaria.AgregarMascotaTrabajador(nombreMascota, raza, dueño, genero, fechaIngreso, horaIngreso, codigoCliente);
            }
            Console.WriteLine("Datos aleatorios para Trabajador generados exitosamente.");
        }

       public static string GenerarCodigoCliente()
       {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return $"C-{random.Next(1000, 9999)}"; 
       }

    }
}
