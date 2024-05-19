using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un año: ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int year))
        {
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            
            if (isLeapYear)
            {
                Console.WriteLine($"{year} es un año bisiesto.");
            }
            else
            {
                Console.WriteLine($"{year} no es un año bisiesto.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
}
