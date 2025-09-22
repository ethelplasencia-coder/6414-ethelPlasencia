﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiondetemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura en grados Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            
            Console.WriteLine("La temperatura en Fahrenheit es: " + fahrenheit);
            Console.WriteLine("La temperatura en Kelvin es: " + kelvin);
            Console.ReadKey();

        }
    }
}
