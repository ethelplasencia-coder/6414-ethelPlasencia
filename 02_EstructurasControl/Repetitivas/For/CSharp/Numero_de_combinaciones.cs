using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_de_combinaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calcula el numero de combinaciones que se puede realizar con nª de polos y pantalones

            Console.WriteLine("Ingresa el numero de polos: ");
            int polos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de pantalones: ");
            int pantalones = Convert.ToInt32(Console.ReadLine());
            int combinaciones = 0;

            for (int i = 1; i <= polos; i++)
            {
                for (int j = 1; j <= pantalones; j++)
                {
                    combinaciones++;
                    
                }
                

            }
            Console.WriteLine("Se puede realizar: " + combinaciones + " combinaciones");
            Console.ReadLine();
        }
    }
}
