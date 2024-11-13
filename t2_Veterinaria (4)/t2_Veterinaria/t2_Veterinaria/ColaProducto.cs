using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class ColaProducto
    {
        public string Producto { get; set; }
        public ColaProducto Siguiente { get; set; }

        public ColaProducto(string producto)
        {
            Producto = producto;
            Siguiente = null;
        }
    }
    public class ColaProductos
    {
        private ColaProducto frente;
        private ColaProducto final;

        public ColaProductos()
        {
            frente = null;
            final = null;
        }

        public void Enqueue(string producto)
        {
            ColaProducto nuevoNodo = new ColaProducto(producto);
            if (final == null)
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }
        }

        public string Dequeue()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (frente == null)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            string producto = frente.Producto;
            frente = frente.Siguiente;
            if (frente == null)
            {
                final = null;
            }
            return producto;
        }

        public bool IsEmpty()
        {
            return frente == null;
        }

        public void MostrarCola()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            ColaProducto actual = frente;
            Console.WriteLine("Productos en la cola:");
            while (actual != null)
            {
                Console.WriteLine(actual.Producto);
                actual = actual.Siguiente;
            }
        }
    }
}
