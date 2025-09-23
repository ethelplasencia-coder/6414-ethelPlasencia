using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_pagohorasextras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double horas, horasextras, tarifa, pago;

            Console.WriteLine("Ingrese las horas de trabajo");
            horas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tarifa por hora");
            tarifa = Convert.ToDouble(Console.ReadLine());

            if (horas <= 40)
            {
                pago = horas * tarifa;
            }
            else
            {
                horasextras = horas - 40;
                pago = (40 * tarifa) + (horasextras * tarifa * 1.15);
            }
            Console.WriteLine("El pago es: " + pago);

        }
    }
}
