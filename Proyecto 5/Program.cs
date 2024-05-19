using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, ingrese una cadena de texto:");
        string input = Console.ReadLine();
        
        string processedInput = input.Replace(" ", "").ToLower();

        bool esPalindromo = true;
        int length = processedInput.Length;
        Console.WriteLine("La cadena procesada es:" + processedInput);
        for (int i = 0; i < length / 2; i++)
        {
            if (processedInput[i] != processedInput[length - 1 - i])
            {
                esPalindromo = false;
                break;
            }
        }

        if (esPalindromo)
        {
            Console.WriteLine("La cadena es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La cadena no es un palíndromo.");
        }
    }
}
