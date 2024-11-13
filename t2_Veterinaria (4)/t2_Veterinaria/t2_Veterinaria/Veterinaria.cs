using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    
    class Veterinaria
    {
        public NodoAdministrador cabezaAdmin;
        public NodoTrabajador cabezaTrabajador;
        public NodoCliente cabezaCliente;


        public void MenuRecepcionMedicamentos()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("=============================================");
                Console.WriteLine("  RECEPCIÓN DE MEDICAMENTOS Y PRODUCTOS VETERINARIOS  ");
                Console.WriteLine("=============================================");

                Console.WriteLine("1. Agregar Medicamento a la Pila");
                Console.WriteLine("2. Procesar Medicamento(Pila)");
                Console.WriteLine("3.  Mostrar Medicamento en Pila");
                Console.WriteLine("4. Agregar Producto a la Cola");
                Console.WriteLine("5. Procesar Producto (Cola)");
                Console.WriteLine("6.  Mostrar Producto en Cola");
                Console.WriteLine("7. Volver");
                Console.WriteLine("Seleccione una ocpión:");
                string opcion = Console.ReadLine();

                if (opcion == "7") break;

                switch (opcion)
                {
                    case "1":
                        Program.AgregarMedicamento();
                        break;
                    case "2":
                        Program.ProcesarMedicamentos();
                        break;
                    case "3":
                        Program.MostrarPilaMedicamentos();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "4":
                        Program.AgregarProducto();
                        break;
                    case "5":
                        Program.ProcesarProducto();
                        break;
                    case "6":
                        Program.MostrarColaProducto();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo");
                        break;
                }
            }
        }
           
        public void AgregarMascotaAdmin(string nombreMascota, string raza, string dueño, string genero, DateTime fechaIngreso, string horaIngreso, string codigoCliente)
        {

            NodoAdministrador nuevoNodo = new NodoAdministrador(nombreMascota, raza, dueño, genero, fechaIngreso, horaIngreso, codigoCliente);
            if (cabezaAdmin == null)
            {
                cabezaAdmin = nuevoNodo;
            }
            else
            {
                NodoAdministrador actual = cabezaAdmin;
                while (actual.Sgte != null)
                {
                    actual = actual.Sgte;
                }
                actual.Sgte = nuevoNodo;
            }
        }

        public void EliminarMascotaAdmin(string nombreMascota)
        {
            if (cabezaAdmin == null) return;

            if (cabezaAdmin.NombreMascota.Equals(nombreMascota, StringComparison.OrdinalIgnoreCase))
            {
                cabezaAdmin = cabezaAdmin.Sgte; 
                return;
            }

            NodoAdministrador actual = cabezaAdmin;
            while (actual.Sgte != null)
            {
                if (actual.Sgte.NombreMascota.Equals(nombreMascota, StringComparison.OrdinalIgnoreCase))
                {
                    actual.Sgte = actual.Sgte.Sgte; 
                    return;
                }
                actual = actual.Sgte;
            }
        }

        public NodoAdministrador BuscarMascotaAdmin(string nombreMascota)
        {
            NodoAdministrador actual = cabezaAdmin;
            while (actual != null)
            {
                if (actual.NombreMascota.Equals(nombreMascota, StringComparison.OrdinalIgnoreCase))
                {
                    return actual;
                }
                actual = actual.Sgte;
            }
            return null; 
        }

      

        public void AgregarMascotaTrabajador(string nombreMascota, string raza, string dueño, string genero, DateTime fechaIngreso, string horaIngreso, string codigoCliente)
        {
            NodoTrabajador nuevoNodo = new NodoTrabajador(nombreMascota, raza, dueño, genero, fechaIngreso, horaIngreso, codigoCliente);
            if (cabezaTrabajador == null)
            {
                cabezaTrabajador = nuevoNodo;
            }
            else
            {
                NodoTrabajador actual = cabezaTrabajador;
                while (actual.Sgte != null)
                {
                    actual = actual.Sgte;
                }
                actual.Sgte = nuevoNodo;
            }
        }

        public void EliminarMascotaTrabajador(string nombreMascota)
        {
            if (cabezaTrabajador == null) return;

            if (cabezaTrabajador.NombreMascota.Equals(nombreMascota, StringComparison.OrdinalIgnoreCase))
            {
                cabezaTrabajador = cabezaTrabajador.Sgte; 
                return;
            }

            NodoTrabajador actual = cabezaTrabajador;
            while (actual.Sgte != null)
            {
                if (actual.Sgte.NombreMascota.Equals(nombreMascota, StringComparison.OrdinalIgnoreCase))
                {
                    actual.Sgte = actual.Sgte.Sgte; 
                    return;
                }
                actual = actual.Sgte;
            }
        }


        public NodoTrabajador BuscarMascotaTrabajador(string nombreMascota)
        {
            NodoTrabajador actual = cabezaTrabajador;
            while (actual != null)
            {
                if (actual.NombreMascota.Equals(nombreMascota, StringComparison.OrdinalIgnoreCase))
                {
                    return actual; 
                }
                actual = actual.Sgte;
            }
            return null; 
        }

        

        public void AgregarMascotaCliente(string nombreMascota, string razaMascota, string nombreDueño, string generoMascota, DateTime fechaIngreso, string horaIngreso, string codigoCliente)
        {
            NodoCliente nuevoNodo = new NodoCliente(nombreMascota, razaMascota, nombreDueño, generoMascota, fechaIngreso, horaIngreso, codigoCliente);
            if (cabezaCliente == null)
            {
                cabezaCliente = nuevoNodo;
            }
            else
            {
                NodoCliente actual = cabezaCliente;
                while (actual.Sgte != null)
                {
                    actual = actual.Sgte;
                }
                actual.Sgte = nuevoNodo;
            }
        }
        public void MostrarReporteCliente()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            NodoCliente nodoClienteActual = cabezaCliente;
            

            // Cabecera del reporte
            Console.WriteLine("Reporte de Mascotas:");
            Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------+--------------------------");
            Console.WriteLine($"{"Nombre",-10}|{"Raza",-15}|{"Genero",-10}|{"Dueño",-10}|{"Fecha de Ingreso",-18}|{"Hora de Ingreso",-20}|{"Código",-15}|{"Tipo"}");
            Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------+--------------------------");

            // Imprimir los clientes
            while (nodoClienteActual != null)
            {
                Console.WriteLine($"{nodoClienteActual.NombreMascota,-10} {nodoClienteActual.Raza,-15} {nodoClienteActual.Genero,-10} {nodoClienteActual.Dueño,-10} {nodoClienteActual.FechaIngreso.ToShortDateString(),-18} {nodoClienteActual.HoraIngreso,-20} {nodoClienteActual.CodigoCliente,-15} {"Cliente"}");
                nodoClienteActual = nodoClienteActual.Sgte;
            }
            // Fin del reporte
            Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------+--------------------------");
        }

        public void MostrarReporte()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            NodoCliente nodoClienteActual = cabezaCliente;
            NodoTrabajador nodoTrabajadorActual = cabezaTrabajador;
            NodoAdministrador nodoAdminActual = cabezaAdmin;

            Console.WriteLine("Reporte de Mascotas:");
            Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------+--------------------------");
            Console.WriteLine($"{"Nombre",-10}|{"Raza",-15}|{"Genero",-10}|{"Dueño",-10}|{"Fecha de Ingreso",-18}|{"Hora de Ingreso",-20}|{"Código",-15}|{"Tipo"}");
            Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------+--------------------------");

            while (nodoClienteActual != null)
            {
                Console.WriteLine($"{nodoClienteActual.NombreMascota,-10} {nodoClienteActual.Raza,-15} {nodoClienteActual.Genero,-10} {nodoClienteActual.Dueño,-10} {nodoClienteActual.FechaIngreso.ToShortDateString(),-18} {nodoClienteActual.HoraIngreso,-20} {nodoClienteActual.CodigoCliente,-15} {"Cliente"}");
                nodoClienteActual = nodoClienteActual.Sgte;
            }

            while (nodoTrabajadorActual != null)
            {
                Console.WriteLine($"{nodoTrabajadorActual.NombreMascota,-10} {nodoTrabajadorActual.Raza,-15} {nodoTrabajadorActual.Genero,-10} {nodoTrabajadorActual.Dueño,-10} {nodoTrabajadorActual.FechaIngreso.ToShortDateString(),-18} {nodoTrabajadorActual.HoraIngreso,-20} {nodoTrabajadorActual.CodigoTrabajador,-15} {"Trabajador"}");
                nodoTrabajadorActual = nodoTrabajadorActual.Sgte;
            }

            while (nodoAdminActual != null)
            {
                Console.WriteLine($"{nodoAdminActual.NombreMascota,-10} {nodoAdminActual.Raza,-15} {nodoAdminActual.Genero,-10} {nodoAdminActual.Dueño,-10} {nodoAdminActual.FechaIngreso.ToShortDateString(),-18} {nodoAdminActual.HoraIngreso,-20} {nodoAdminActual.CodigoAdministrador,-15} {"Administrador"}");
                nodoAdminActual = nodoAdminActual.Sgte;
            }

            // Fin del reporte
            Console.WriteLine("--------+---------------+---------------------+----------------------------------+-------------------+--------------------------");
        }



    }
}
