using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido!");
            Console.WriteLine("¡Este programa se encarga de calcular por usted su peso ideal!");
            Console.WriteLine("Para continuar, presione Enter.");
            Console.ReadLine(); 

            double peso = 0, altura = 0;

            while (true)
            {
                try
                {
                    Console.Write("Por favor, ingrese su peso en kilos: ");
                    peso = double.Parse(Console.ReadLine());
                    if (peso <= 0) throw new Exception("El peso debe ser un número positivo.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Entrada inválida. " + ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Por favor, ingrese su altura en metros: ");
                    altura = double.Parse(Console.ReadLine());
                    if (altura <= 0) throw new Exception("La altura debe ser un número positivo.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Entrada inválida. " + ex.Message);
                }
            }

            double imc = peso / (altura * altura);
            Console.WriteLine("Su IMC es: " + imc.ToString("F2"));
            Console.WriteLine("Por lo que usted está en la categoría de:");

            string categoria;
            if (imc < 18.5)
            {
                categoria = "Bajo peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                categoria = "Peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                categoria = "Sobrepeso";
            }
            else
            {
                categoria = "Obesidad";
            }

            Console.WriteLine($"Categoría del IMC: {categoria}");
        }
    }
}
