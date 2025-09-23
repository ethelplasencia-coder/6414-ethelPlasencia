using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelis_segun_edad
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Le pide al usuario su edad, y segun la edad le muestra que tipo de peliculas puede mirar

            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 14)
            {
                Console.WriteLine("Puede ver peliculas de comedia, romantica y ciencia ficciòn");

                if (edad < 6)
                    Console.WriteLine("Pero con el acompañamiento de un adulto");
            }
            else
            {
                Console.WriteLine("Puede ver peliculas de terror, acciòn y entre otras");
            }
            Console.ReadKey();
        }
    }
}
