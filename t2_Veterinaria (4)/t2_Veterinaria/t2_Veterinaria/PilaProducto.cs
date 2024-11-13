using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class PilaProducto
    {
        public string Medicamento { get; set; }
        public PilaProducto Siguiente { get; set; }

        public PilaProducto(string medicamento)
        {
            Medicamento = medicamento;
            Siguiente = null;
        }
    }
    public class PilaMedicamentos
    {
        private PilaProducto cima;

        public PilaMedicamentos()
        {
            cima = null;
        }

        public void Push(string medicamento)
        {
            PilaProducto nuevoNodo = new PilaProducto(medicamento);
            nuevoNodo.Siguiente = cima;
            cima = nuevoNodo;
        }

        public string Pop()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (cima == null)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            string medicamento = cima.Medicamento;
            cima = cima.Siguiente;
            return medicamento;
        }

        public bool IsEmpty()
        {
            return cima == null;
        }

        public void MostrarPila()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            PilaProducto actual = cima;
            Console.WriteLine("Medicamentos en la pila:");
            while (actual != null)
            {
                Console.WriteLine(actual.Medicamento);
                actual = actual.Siguiente;
            }
        }
    }
}
