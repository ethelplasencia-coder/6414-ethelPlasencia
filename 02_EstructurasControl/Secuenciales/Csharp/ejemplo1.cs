using System;
class PromedioNotas
{
    static void Main()
    {
        Console.WriteLine("Ingrese la primera nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio de las notas es: " + promedio);
    }
}