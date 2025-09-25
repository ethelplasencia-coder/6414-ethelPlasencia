using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            int puntos = 0;

            while (opcion != "3")
            {
                Console.WriteLine("\n=== MENU DEL JUEGO ===");
                Console.WriteLine("1. Preguntas");
                Console.WriteLine("2. Completar palabras");
                Console.WriteLine("3. Resultados y salir");
                Console.Write("Elige una opción: ");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("\n--- PREGUNTAS ---");
                    Console.WriteLine("1) ¿Qué nutriente falta comúnmente en la anemia?");
                    Console.WriteLine("1. Calcio");
                    Console.WriteLine("2. Hierro");
                    Console.WriteLine("3. Sodio");
                    Console.Write("Elige la opción correcta: ");
                    string respuesta = Console.ReadLine();

                    if (respuesta == "2")
                    {
                        Console.WriteLine("¡Correcto!");
                        puntos++; 
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                    }
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("\n--- COMPLETAR PALABRAS ---");
                    Console.WriteLine("A_EMI_");
                    Console.WriteLine("Elige la opción correcta:");
                    Console.WriteLine("1. A-O");
                    Console.WriteLine("2. N-A");
                    Console.WriteLine("3. D-M");
                    Console.Write("Tu respuesta: ");
                    string respuesta = Console.ReadLine();

                    if (respuesta == "2")
                    {
                        Console.WriteLine("¡Correcto!");
                        puntos++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                    }
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("\n--- RESULTADOS ---");
                    Console.WriteLine($"Tu puntaje total es: {puntos}");
                    Console.WriteLine("¡Gracias por jugar!");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                }
            }
        }
    }   
}
