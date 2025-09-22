using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Verificación de Número Par ===");
            Console.WriteLine();

            Console.WriteLine("Ingrese un número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Condicional doble
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
            Console.ReadKey();
        }
    }
}
