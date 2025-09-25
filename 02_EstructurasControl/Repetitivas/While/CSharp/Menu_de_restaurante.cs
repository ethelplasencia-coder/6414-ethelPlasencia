using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string opcion = "";

            while (opcion != "4")
            {

                Console.WriteLine("\n=== MENÙ ===");
                Console.WriteLine("1. Almuerzos");
                Console.WriteLine("2. Postres");
                Console.WriteLine("3. Bebidas");
                Console.WriteLine("4. Ver cuenta y salir");
                Console.Write("Elige una opción: ");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("\n--- Almuerzos ---");
                    Console.WriteLine("a. Pizza - s/.12.50");
                    Console.WriteLine("c. Ensalada - s/.7.50");
                    Console.WriteLine("b. Hamburguesa - s/.10.00");
                    Console.Write("Elige tu plato: ");
                    string plato = Console.ReadLine();

                    if (plato == "a")
                    {
                        total += 12.50;
                        Console.WriteLine("Has pedido Pizza ");
                    }
                    else if (plato == "b")
                    {
                        total += 10.00;

                        Console.WriteLine("Has pedido Hamburguesa");
                    }
                    else if (plato == "c")
                    {
                        total += 7.50;
                        Console.WriteLine("Has pedido Ensalada ");
                    }
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("\n--- Postres ---");
                    Console.WriteLine("a. Helado - s/.5.00");
                    Console.WriteLine("b. Pastel - s/.6.50");
                    Console.WriteLine("c. Fruta - s/.4.00");
                    Console.Write("Elige tu postre: ");
                    string postre = Console.ReadLine();

                    if (postre == "a")
                    {
                        total += 5.00;
                        Console.WriteLine("Has pedido Helado");
                    }
                    else if (postre == "b")
                    {
                        total += 6.50;
                        Console.WriteLine("Has pedido Pastel");
                    }
                    else if (postre == "c")
                    {
                        total += 4.00;
                        Console.WriteLine("Has pedido Fruta");
                    }
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("\n--- Bebidas ---");
                    Console.WriteLine("a. Agua - s/.2.00");
                    Console.WriteLine("b. Jugo - s/.3.50");
                    Console.WriteLine("c. Refresco - s/.2.50");
                    Console.Write("Elige tu bebida: ");
                    string bebida = Console.ReadLine();

                    if (bebida == "a")
                    {
                        total += 2.00;

                        Console.WriteLine("Has pedido Agua");
                    }
                    else if (bebida == "b")
                    {
                        total += 3.50;

                        Console.WriteLine("Has pedido Jugo");
                    }
                    else if (bebida == "c")
                    {
                        total += 2.50;

                        Console.WriteLine("Has pedido Refresco");
                    }
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("\n--- Resumen de tu pedido ---");
                    Console.WriteLine($"Total a pagar: s/. {total}");
                    Console.WriteLine("¡Gracias por tu visita!");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intenta nuevamente.");

                }
              Console.ReadKey();
            }
        }
    }
}
