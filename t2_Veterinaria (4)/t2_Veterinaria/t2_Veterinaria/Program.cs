using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Animacion.Interactua();
            Veterinaria veterinaria = new Veterinaria();


            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("          MENÚ PRINCIPAL");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Administrador");
                Console.WriteLine("2. Trabajador");
                Console.WriteLine("3. Cliente");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "4") break;

                switch (opcion)
                {
                    case "1":
                        MenuAdministrador(veterinaria);
                        break;
                    case "2":
                        MenuTrabajador(veterinaria);
                        break;
                    case "3":
                        MenuCliente(veterinaria);
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }

        private static void MenuAdministrador(Veterinaria veterinaria)
        {
            ListasConsultas listaConsultas = new ListasConsultas();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("     MENÚ ADMINISTRADOR");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Gestión de Mascotas");
                Console.WriteLine("2. Programación de Consultas");
                Console.WriteLine("3. Recepcion de Medicamentos");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "4") break;

                switch (opcion)
                {
                    case "1":
                        GestionMascotasAdmin(veterinaria);
                        break;
                    case "2":
                        ProgramacionDeConsultasAdmin(listaConsultas); 
                        break;

                    case "3":
                        veterinaria.MenuRecepcionMedicamentos();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }

        private static void GestionMascotasAdmin(Veterinaria veterinaria)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("     GESTIÓN DE MASCOTAS - ADMINISTRADOR");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Agregar Mascota");
                Console.WriteLine("2. Eliminar Mascota");
                Console.WriteLine("3. Buscar Mascota");
                Console.WriteLine("4. Mostrar Reporte de Mascotas");
                Console.WriteLine("5. Generar Datos Aleatorios");
                Console.WriteLine("6. Volver");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "6") break;

                switch (opcion)
                {
                    case "1":
                        AgregarMascota(veterinaria, true);
                        break;
                    case "2":
                        EliminarMascota(veterinaria, true);
                        break;
                    case "3":
                        BuscarMascota(veterinaria, true);
                        break;
                    case "4":
                        veterinaria.MostrarReporte();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "5":
                        GeneradorDatos.GenerarDatosAdministrador(veterinaria);
                        Console.WriteLine("Datos aleatorios generados. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }
        private static void ProgramacionDeConsultasAdmin(ListasConsultas listaConsultas)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("   PROGRAMACIÓN DE CONSULTAS");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Agregar Consulta");
                Console.WriteLine("2. Eliminar Consulta");
                Console.WriteLine("3. Buscar Consulta");
                Console.WriteLine("4. Mostrar Consultas");
                Console.WriteLine("5. Generar Consultas Aleatorias");
                Console.WriteLine("6. Volver");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "6") break;

                switch (opcion)
                {
                    case "1":
                        AgregarConsulta(listaConsultas);
                        break;
                    case "2":
                        EliminarConsulta(listaConsultas);
                        break;
                    case "3":
                        BuscarConsulta(listaConsultas);
                        break;
                    case "4":
                        listaConsultas.MostrarConsultas();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "5":
                        ConsultasAleatoriamente.GenerarConsultasAleatorias(listaConsultas, 10);
                        Console.WriteLine("Consultas generadas aleatoriamente.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public static void AgregarConsulta(ListasConsultas listaConsultas)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string nombreCliente = Console.ReadLine();

            Console.Write("Ingrese el nombre de la mascota: ");
            string nombreMascota = Console.ReadLine();

            Console.Write("Ingrese la raza de la mascota: ");
            string razaMascota = Console.ReadLine();

            Console.Write("Ingrese el tipo de consulta: ");
            string tipoConsulta = Console.ReadLine(); 
            Console.WriteLine("Consulta agregada exitosamente.");

            DateTime fechaConsulta = DateTime.Now;

            NodoConsulta nuevaConsulta = new NodoConsulta(nombreCliente, nombreMascota, razaMascota, fechaConsulta, tipoConsulta);
            listaConsultas.AgregarConsulta(nuevaConsulta);
            
        }
        public static void EliminarConsulta(ListasConsultas listaConsultas)
        {

            Console.Write("Ingrese el nombre del cliente o mascota para eliminar la consulta: ");
            string nombre = Console.ReadLine();

            bool eliminado = listaConsultas.EliminarConsulta(nombre);

            if (eliminado)
            {
                Console.WriteLine("Consulta eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró ninguna consulta para eliminar.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static void BuscarConsulta(ListasConsultas listaConsultas)
        {
            Console.Write("Ingrese el nombre del cliente o mascota para buscar la consulta: ");
            string nombre = Console.ReadLine();

           
            NodoConsulta consulta = listaConsultas.BuscarConsulta(nombre);

            if (consulta != null)
            {
                Console.WriteLine("--------+---------------+---------------------+--------------------------------------------");
                Console.WriteLine($"{"Dueño",-8}|{"Nombre",-15}|{"Fecha y hora ",-20}|{"Tipo de consulta",-10}");
                Console.WriteLine("--------+---------------+---------------------+--------------------------------------------");

                Console.WriteLine($"{consulta.NombreCliente, -10}{consulta.NombreMascota, -15}{consulta.FechaHoraConsulta, -21}{consulta.TipoConsulta, -10}");
                Console.WriteLine("--------+---------------+---------------------+--------------------------------------------");

            }
            else
            {
                Console.WriteLine("No se encontró ninguna consulta con ese nombre.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
 
        public static void GenerarConsultasAleatorias(ListasConsultas listaConsultas, int cantidad)
        {
            ConsultasAleatoriamente.GenerarConsultasAleatorias(listaConsultas, cantidad);
            Console.WriteLine($"{cantidad} consultas generadas aleatoriamente.");
        }
        private static void MenuTrabajador(Veterinaria veterinaria)
        {
            
            ListasConsultas listaConsultas = new ListasConsultas();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("     MENÚ TRABAJADOR");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Gestión de Mascotas");
                Console.WriteLine("2. Programacion de consultas");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "3") break;

                switch (opcion)
                {
                    case "1":
                        GestionMascotasTrabajador(veterinaria);
                        break;
                    case "2":
                        ProgramacionConsultasTrabajador(listaConsultas);
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }

        private static void GestionMascotasTrabajador(Veterinaria veterinaria)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("     GESTIÓN DE MASCOTAS - TRABAJADOR");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Agregar Mascota");
                Console.WriteLine("2. Eliminar Mascota");
                Console.WriteLine("3. Buscar Mascota");
                Console.WriteLine("4. Mostrar Reporte de Mascotas");
                Console.WriteLine("5. Generar Datos Aleatorios");
                Console.WriteLine("6. Volver");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "6") break;

                switch (opcion)
                {
                    case "1":
                        AgregarMascota(veterinaria, false);
                        break;
                    case "2":
                        EliminarMascota(veterinaria, false);
                        break;
                    case "3":
                        BuscarMascota(veterinaria, false);
                        break;
                    case "4":
                        veterinaria.MostrarReporte();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "5":
                        GeneradorDatos.GenerarDatosTrabajador(veterinaria);
                        Console.WriteLine("Datos aleatorios generados. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }
        private static void ProgramacionConsultasTrabajador(ListasConsultas listasConsultas)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("   PROGRAMACIÓN DE CONSULTAS");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Agregar Consulta");
                Console.WriteLine("2. Eliminar Consulta");
                Console.WriteLine("3. Buscar Consulta");
                Console.WriteLine("4. Mostrar Consultas");
                Console.WriteLine("5. Generar Consultas Aleatorias");
                Console.WriteLine("6. Volver");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "6") break;

                switch (opcion)
                {
                    case "1":
                        AgregarConsulta(listasConsultas);
                        break;
                    case "2":
                        EliminarConsulta(listasConsultas);
                        break;
                    case "3":
                        BuscarConsulta(listasConsultas);
                        break;
                    case "4":
                        listasConsultas.MostrarConsultas(); 
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "5":
                        ConsultasAleatoriamente.GenerarConsultasAleatorias(listasConsultas, 10);
                        Console.WriteLine("Consultas generadas aleatoriamente.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void MenuCliente(Veterinaria veterinaria)
        {
            ListasConsultas listasConsultas = new ListasConsultas();
            ListasConsultas listasConsultasAdministrador = new ListasConsultas();
            ListasConsultas listasConsultasTrabajador = new ListasConsultas();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("     MENÚ CLIENTE");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Ingresar datos");
                Console.WriteLine("2. Reagendamiento y cancelacion de citas");
                Console.WriteLine("3. Volver");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "3") break;

                switch (opcion)
                {
                    case "1":
                        IngresarDatosCliente(veterinaria);
                        break;
                    case "2":
                        ReagendarCancelarCitas(listasConsultas, listasConsultasAdministrador, listasConsultasTrabajador);
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }
        private static void IngresarDatosCliente (Veterinaria veterinaria)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("     MENÚ CLIENTE");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Agregar Mascota");
                Console.WriteLine("2. Mostrar Reporte de Clientes");
                Console.WriteLine("3. Volver");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "3") break;

                switch (opcion)
                {
                    case "1":
                        AgregarMascotaCliente(veterinaria);
                        break;
                    case "2":
                        veterinaria.MostrarReporteCliente();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }

        private static void ReagendarCancelarCitas(ListasConsultas listaConsultas, ListasConsultas listasConsultasAdministrador, ListasConsultas listasConsultasTrabajador)
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("  REAGENDAR O CANCELAR CITAS");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Agregar nueva cita");
                Console.WriteLine("2. Cancelar cita");
                Console.WriteLine("3. Mostrar consulta");
                Console.WriteLine("4. Volver");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        listaConsultas.AgregarConsultaCliente();
                        Console.WriteLine("Consulta agregada exitosamente.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write("Ingrese el nombre del cliente o la mascota para cancelar la cita: ");
                        string nombre = Console.ReadLine();
                        listaConsultas.CancelarConsultaCliente(nombre);
                        Console.WriteLine("Consulta cancelada exitosamente.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        listaConsultas.MostrarConsultas();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "4":
                        return; 
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private static void AgregarMascota(Veterinaria veterinaria, bool esAdmin)
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("     AGREGAR MASCOTA");
            Console.WriteLine("=======================================");

            Console.Write("Nombre de la mascota: ");
            string nombreMascota = Console.ReadLine();

            Console.Write("Raza: ");
            string raza = Console.ReadLine();

            Console.Write("Dueño: ");
            string dueño = Console.ReadLine();

            Console.Write("Género (Macho/Hembra): ");
            string genero = Console.ReadLine();

            DateTime fechaIngreso = DateTime.Now;

            string horaIngreso = DateTime.Now.ToString("HH:mm");

            string codigoCliente = GeneradorDatos.GenerarCodigoCliente();

            if (esAdmin)
            {
                veterinaria.AgregarMascotaAdmin(nombreMascota, raza, dueño, genero, fechaIngreso, horaIngreso, codigoCliente);
                Console.WriteLine("Mascota agregada exitosamente como Administrador.");
            }
            else
            {
                veterinaria.AgregarMascotaTrabajador(nombreMascota, raza, dueño, genero, fechaIngreso, horaIngreso, codigoCliente);
                Console.WriteLine("Mascota agregada exitosamente como Trabajador.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static void EliminarMascota(Veterinaria veterinaria, bool esAdmin)
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("     ELIMINAR MASCOTA");
            Console.WriteLine("=======================================");

            Console.Write("Nombre de la mascota a eliminar: ");
            string nombreMascota = Console.ReadLine();

            if (esAdmin)
            {
                veterinaria.EliminarMascotaAdmin(nombreMascota);
                Console.WriteLine("Mascota eliminada exitosamente.");
            }
            else
            {
                veterinaria.EliminarMascotaTrabajador(nombreMascota);
                Console.WriteLine("Mascota eliminada exitosamente.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static void BuscarMascota(Veterinaria veterinaria, bool esAdmin)
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("     BUSCAR MASCOTA");
            Console.WriteLine("=======================================");

            Console.Write("Nombre de la mascota a buscar: ");
            string nombreMascota = Console.ReadLine();

            if (esAdmin)
            {
                var mascota = veterinaria.BuscarMascotaAdmin(nombreMascota);
                if (mascota != null)
                {
                    Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------");
                    Console.WriteLine($"{"Nombre",-8}|{"Raza",-15}|{"Dueño",-10}|{"Género",-10}|{"Fecha de Ingreso",-18}|{"Hora de Ingreso",-20}|{"Código Cliente",-15}");
                    Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------");
                    Console.WriteLine($"{mascota.NombreMascota,-9}{mascota.Raza,-16}{mascota.Dueño,-12}{mascota.Genero,-12}{mascota.FechaIngreso.ToShortDateString(),-20}{mascota.HoraIngreso,-21}{mascota.CodigoAdministrador,-15}");
                    Console.WriteLine("----------------------------------------------+------------------------------------------------------");
                    Console.WriteLine("Mascota encontrada con exito ");
                }
                else
                {
                    Console.WriteLine("Mascota no encontrada.");
                }
            }
            else
            {
                var mascota = veterinaria.BuscarMascotaTrabajador(nombreMascota);
                if (mascota != null)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------");
                    Console.WriteLine($"{"Nombre",-8}|{"Raza",-15}|{"Genero",-10}|{"Dueño",-10}|{"Fecha de Ingreso",-18}|{"Hora de Ingreso",-20}|{"Código Cliente",-15}");
                    Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------");
                    Console.WriteLine($"{mascota.NombreMascota,-9}{mascota.Raza,-16}{mascota.Genero,-12}{mascota.Dueño,-12}{mascota.FechaIngreso.ToShortDateString(),-20}{mascota.HoraIngreso,-21}{mascota.CodigoTrabajador,-15}");
                    Console.WriteLine("----------------------------------------------+------------------------------------------------------");
                    Console.WriteLine("Mascota encontrada con exito ");
                }
                else
                {
                    Console.WriteLine("Mascota no encontrada.");
                }
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private static void AgregarMascotaCliente(Veterinaria veterinaria)
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("     AGREGAR MASCOTA - CLIENTE");
            Console.WriteLine("=======================================");

            Console.Write("Nombre de la mascota: ");
            string nombreMascota = Console.ReadLine();

            Console.Write("Raza: ");
            string raza = Console.ReadLine();

            Console.Write("Dueño: ");
            string dueño = Console.ReadLine();

            Console.Write("Género (Macho/Hembra): ");
            string genero = Console.ReadLine();

            DateTime fechaIngreso = DateTime.Now;

            string horaIngreso = DateTime.Now.ToString("HH:mm");

           
            string codigoCliente = GeneradorDatos.GenerarCodigoCliente();

            veterinaria.AgregarMascotaCliente(nombreMascota, raza, dueño, genero, fechaIngreso, horaIngreso, codigoCliente);
            Console.WriteLine("Mascota agregada exitosamente como Cliente.");

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static void AgregarMedicamento()
        {

            Console.WriteLine("Ingrese el nombre del medicamento:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad del medicamento:");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha de recepción del medicamento (formato: yyyy-MM-dd):");
            DateTime fechaRecepcion = DateTime.Parse(Console.ReadLine());


            string medicamentoString = $"{nombre}|{cantidad}|{fechaRecepcion:yyyy-MM-dd}";
            pilaMedicamentos.Push(medicamentoString);
        }
        public static void ProcesarMedicamentos()
        {
            Console.Clear();
            if (!pilaMedicamentos.IsEmpty())
            {
                string medicamento = pilaMedicamentos.Pop();
                Console.WriteLine($"Medicamento'{medicamento}' procesado de la pila.");
            }
            else
            {
                Console.WriteLine("No hay medicamentos en la pila para procesar");
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static void AgregarProducto()
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad del producto:");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha de recepción del producto (formato: yyyy-MM-dd):");
            DateTime fechaRecepcion = DateTime.Parse(Console.ReadLine());

            string productoString = $"{nombre}|{cantidad}|{fechaRecepcion:yyyy-MM-dd}";
            colaProductos.Enqueue(productoString);
        }
        public static PilaMedicamentos pilaMedicamentos = new PilaMedicamentos();
        public static ColaProductos colaProductos = new ColaProductos();

        public static void ProcesarProducto()
        {
            Console.Clear();
            if (!colaProductos.IsEmpty())
            {
                string producto = colaProductos.Dequeue();
                Console.WriteLine($"Producto '{producto}' procesado de la cola.");
            }
            else
            {
                Console.WriteLine("No hay productos en la cola para procesar.");
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static void MostrarColaProducto()
        {
            if (colaProductos.IsEmpty())
            {
                Console.WriteLine("La cola de productos está vacía.");
            }
            else
            {
                colaProductos.MostrarCola();
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static void MostrarPilaMedicamentos()
        {
            if (pilaMedicamentos.IsEmpty())
            {
                Console.WriteLine("La pila de medicamentos está vacía.");
            }
            else
            {
                pilaMedicamentos.MostrarPila();
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
