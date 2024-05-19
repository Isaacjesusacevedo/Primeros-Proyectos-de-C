using System;

class Program
{
    static void Main(string[] args)
    {
        double numero1, numero2, resultado;
        string operacion;

        Console.WriteLine("Calculadora Básica en C#");
        Console.ReadKey();
        // Solicitar la operación
        Console.WriteLine("Seleccione la operación a realizar:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Ingrese el número de la operación: ");
        operacion = Console.ReadLine();
        // Solicitar el primer número
        Console.Write("Ingrese el primer número: ");
        while (!double.TryParse(Console.ReadLine(), out numero1))
        {
            Console.Write("Entrada no válida. Ingrese un número válido: ");
        }

        // Solicitar el segundo número
        Console.Write("Ingrese el segundo número: ");
        while (!double.TryParse(Console.ReadLine(), out numero2))
        {
            Console.Write("Entrada no válida. Ingrese un número válido: ");
        }

        try
        {
            switch (operacion)
            {
                case "1":
                    resultado = Sumar(numero1, numero2);
                    Console.WriteLine($"\nResultado: {numero1} + {numero2} = {resultado}");
                    break;
                case "2":
                    resultado = Restar(numero1, numero2);
                    Console.WriteLine($"\nResultado: {numero1} - {numero2} = {resultado}");
                    break;
                case "3":
                    resultado = Multiplicar(numero1, numero2);
                    Console.WriteLine($"\nResultado: {numero1} * {numero2} = {resultado}");
                    break;
                case "4":
                    resultado = Dividir(numero1, numero2);
                    Console.WriteLine($"\nResultado: {numero1} / {numero2} = {resultado}");
                    break;
                default:
                    Console.WriteLine("\nOperación no válida. Por favor, seleccione una operación del 1 al 4.");
                    break;
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("\nError: No se puede dividir entre cero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
    }

    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Restar(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}
