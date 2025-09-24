using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleccion_zapatillas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // El programa muestra modelos de zapatillas segun la marca que elija (ADIDAS,NIKE,PUMA)

            Console.WriteLine("Ingrese la marca que desee (ADIDAS,NIKE,PUMA)");
            string marca = Convert.ToString(Console.ReadLine());

            if (marca == "ADIDAS")
            {
                Console.WriteLine("---ZAPATILLAS ADIDAS---");

                Console.WriteLine("Adidas Ultraboost Light");
                Console.WriteLine("Adidas Samba OG");
                Console.WriteLine("Adidas NMD_R1");
            }
            else if (marca == "NIKE")
            {
                Console.WriteLine("---ZAPATILLAS NIKE---");

                Console.WriteLine("Nike Air Force 1");
                Console.WriteLine("Nike Air Max 90");
                Console.WriteLine("Nike Dunk Low");

            }
            else if (marca == "PUMA")
            {
                Console.WriteLine("---ZAPATILLAS ADIDAS---");

                Console.WriteLine("Puma Suede Classic");
                Console.WriteLine("Puma RS-X");
                Console.WriteLine("Puma Cali");
            }
            else
            {
                Console.WriteLine("Marca no reconocida");
            }
            Console.ReadKey();
        }    
                
    }
}
