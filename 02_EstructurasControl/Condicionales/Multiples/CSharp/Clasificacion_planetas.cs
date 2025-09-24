using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificacion_planetas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // El programa presenta una caracterìstica de un planeta, segun el nùmero que indique el usuario.

            Console.Write("Ingrese el número del planeta (1 al 8): ");
            int planeta = int.Parse(Console.ReadLine());

            switch (planeta)
            {
                case 1:
                    Console.WriteLine("Mercurio → El más cercano al Sol.");
                    break;
                case 2:
                    Console.WriteLine("Venus → El planeta más caliente.");
                    break;
                case 3:
                    Console.WriteLine("Tierra → ¡Nuestro hogar!");
                    break;
                case 4:
                    Console.WriteLine("Marte → Conocido como el planeta rojo.");
                    break;
                case 5:
                    Console.WriteLine("Júpiter → El más grande del sistema solar.");
                    break;
                case 6:
                    Console.WriteLine("Saturno → Reconocido por sus anillos.");
                    break;
                case 7:
                    Console.WriteLine("Urano → Gira de costado.");
                    break;
                case 8:
                    Console.WriteLine("Neptuno → El más lejano al Sol.");
                    break;
                default:
                    Console.WriteLine("Número inválido, solo hay 8 planetas principales.");
                    break;
            }
        }

    }
}

