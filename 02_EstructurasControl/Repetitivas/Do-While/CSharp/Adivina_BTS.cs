using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_BTS.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra, respuesta;
             
            Console.WriteLine("Escribe un numero del 1 a 7 o SALIR, y adivina el personaje de BTS");
            palabra = Console.ReadLine();

            do
            {
                Console.Write("\nTu numero es : " + palabra );
                

                if (palabra == "1")
                {
                    Console.WriteLine(" Es el menor del grupo. ¿quien es?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "Jungkook")
                    {
                        Console.WriteLine("¡ADIVINASTE!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("¡NO ADIVINASTE!");
                    }
                }
                else if (palabra == "2")
                {
                    Console.WriteLine(" Es el mayor del grupo. ¿quien es?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "Jin")
                    {
                       Console.WriteLine("¡ADIVINASTE!");
                        break;
                    }  
                    else
                    {
                       Console.WriteLine("¡NO ADIVINASTE!");
                    }
                }
                else if (palabra == "3") 
                {
                     Console.WriteLine(" Es el lider del grupo. ¿quien es?");
                     respuesta = Console.ReadLine();
                     if (respuesta == "RM")
                     {
                         Console.WriteLine("¡ADIVINASTE!");
                         break;
                     }  
                     else
                     {
                         Console.WriteLine("¡NO ADIVINASTE!");
                     }
                }
                else if (palabra == "4")
                {
                    Console.WriteLine(" Es el màs dormilon del grupo. ¿quien es?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "Suga")
                    {
                        Console.WriteLine("¡ADIVINASTE!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("¡NO ADIVINASTE!");
                    }
                }
                else if (palabra == "5")
                {
                    Console.WriteLine(" Tiene personalidad amistosa, carismática y alegre. ¿quien es?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "V")
                    {
                        Console.WriteLine("¡ADIVINASTE!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("¡NO ADIVINASTE!");
                    }
                }
                else if (palabra == "6")
                {
                    Console.WriteLine(" Es conocido como \"La luz del sol\" ¿quien es?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "Jhope")
                    {
                        Console.WriteLine("¡ADIVINASTE!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("¡NO ADIVINASTE!");
                    }
                }
                else if (palabra == "7")
                {
                    Console.WriteLine(" Es el màs pequeño del grupo. ¿quien es?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "Jimin")
                    {
                        Console.WriteLine("¡ADIVINASTE!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("¡NO ADIVINASTE!");
                    }
                }
                if (palabra.ToUpper() == "SALIR")
                {
                    break; 
                }

            } while (true);
            Console.WriteLine(" ¡Puerta abierta!");
        }
    }
}
