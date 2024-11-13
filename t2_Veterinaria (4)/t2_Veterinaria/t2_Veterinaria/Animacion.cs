using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace t2_Veterinaria
{
    internal class Animacion
    {
        public static void Interactua()
        {

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t\t\t █████╗ ██╗     ██╗███╗  ██╗██╗ █████╗  █████╗ ");
            Console.WriteLine("\t\t\t██╔══██╗██║     ██║████╗ ██║██║██╔══██╗██╔══██╗");
            Console.WriteLine("\t\t\t██║  ╚═╝██║     ██║██╔██╗██║██║██║  ╚═╝███████║");
            Console.WriteLine("\t\t\t██║  ██╗██║     ██║██║╚████║██║██║  ██╗██╔══██)");
            Console.WriteLine("\t\t\t╚█████╔╝███████╗██║██║ ╚███║██║╚█████╔╝██║  ██║");
            Console.WriteLine("\t\t\t ╚════╝ ╚══════╝╚═╝╚═╝  ╚══╝╚═╝ ╚════╝ ╚═╝  ╚═╝");
            Console.WriteLine("\t██╗   ██╗███████╗████████╗███████╗██████╗ ██╗███╗  ██╗ █████╗ ██████╗ ██╗ █████╗ ");
            Console.WriteLine("\t██║   ██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗██║████╗ ██║██╔══██╗██╔══██╗██║██╔══██╗");
            Console.WriteLine("\t╚██╗ ██╔╝█████╗     ██║   █████╗  ██████╔╝██║██╔██╗██║███████║██████╔╝██║███████║");
            Console.WriteLine("\t ╚████╔╝ ██╔══╝     ██║   ██╔══╝  ██╔══██╗██║██║╚████║██╔══██║██╔══██╗██║██╔══██║");
            Console.WriteLine("\t  ╚██╔╝  ███████╗   ██║   ███████╗██║  ██║██║██║ ╚███║██║  ██║██║  ██║██║██║  ██║");
            Console.WriteLine("\t   ╚═╝   ╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝╚═╝  ╚══╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚═╝  ╚═╝");
            Console.Write("\tCargando: [");

            for (int i = 0; i < 50; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }

            Console.Write("]\n");
            Console.Clear();
        }
    }
}
