using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calcula el ahorro semanal 
            double ahorro = 0;
            Console.WriteLine("¿Cuanto ahorras por dìa?");
            double dinero = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 7; i++)
            {

                ahorro = ahorro + dinero;

            }
            Console.WriteLine("Tu ahorro total durante la semana es de: " + ahorro);
            Console.ReadKey (); 
        }
    }
}
