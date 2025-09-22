using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuesto_a_la_Renta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculo de Impuesto a la Renta ===");
            Console.WriteLine();

            Console.WriteLine("Ingrese el monto de su renta en soles:");
            double renta = Convert.ToDouble(Console.ReadLine());

            // Condicional simple
            if (renta > 4000)
            {
                double impuesto = renta * 0.05;
                Console.WriteLine("El impuesto a pagar es: S/ " + impuesto);
            }


        }
    }
}
