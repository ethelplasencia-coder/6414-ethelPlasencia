using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_palabrasecreta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            do
            {
                Console.WriteLine("===PISTAS===");
                Console.WriteLine("Es una estrella de plasma");
                Console.WriteLine("Es muy caliente");
                Console.WriteLine();
                Console.Write("Escribe la palabra secreta: ");
                palabra = Console.ReadLine();
            } while (palabra != "sol");

            Console.WriteLine("¡Correcto!");
        }
    }
}
