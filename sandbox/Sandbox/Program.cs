using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("OLá Mundo! This is the Sandbox Project.");
        Console.WriteLine("Isto está em C#");

        Console.Write("Qual é a sua cor favorita? ");
        string cor = Console.ReadLine();
        Console.WriteLine($"Sua cor favorita é {cor}");

        int numero = 5;

        if (numero > 3)
        {
            Console.WriteLine($"O número é: {numero}");
            
        }
    }
}