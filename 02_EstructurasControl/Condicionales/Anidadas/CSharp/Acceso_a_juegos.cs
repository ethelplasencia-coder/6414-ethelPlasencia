using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_juegos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Este programa verifica si se puede ingresar a la montaña rusa teniendo en cuenta la edad y la estatura.

            Console.WriteLine("Ingrese su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su estatura en cm:");
            int estatura = Convert.ToInt32(Console.ReadLine());

            if (edad >= 12)
            {
                Console.WriteLine("Puedes entrar a la montaña rusa.");

                if (estatura < 140)
                {
                    Console.WriteLine("Pero debes ir acompañado de un adulto por tu estatura.");
                }
            }
            else
            {
                Console.WriteLine("Puedes entrar solo a los juegos infantiles.");
            }
            Console.ReadKey();
        }
    }
}
