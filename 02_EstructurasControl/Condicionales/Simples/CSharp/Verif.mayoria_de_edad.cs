using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verif.mayoria_de_edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Verificación de Mayoría de Edad ===");
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

           
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }

            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();

        }
    }
}
