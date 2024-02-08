using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double C, F;
            string resposta;
            
            do
            {
                Console.Write("Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = (9.0 * C) / 5.0 + 32;
                Console.WriteLine("Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)?");
                resposta = Console.ReadLine();
            } 
            while (resposta == "s");


        }
    }
}