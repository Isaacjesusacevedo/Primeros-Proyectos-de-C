using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            double promedio = (numero1 + numero2 + numero3) / 3;

            Console.WriteLine("El promedio de los tres números es: " + promedio);
        }
    }
}