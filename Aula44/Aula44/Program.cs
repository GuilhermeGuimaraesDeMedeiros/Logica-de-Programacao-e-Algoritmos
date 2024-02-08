using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, n;
            double soma, media;

            x = int.Parse(Console.ReadLine());
            soma = 0;
            n = 0;

            while (x >= 0)
            {
                soma = soma + x;
                n = n + 1;
                x = int.Parse(Console.ReadLine());
            }
            if (n == 0) { Console.WriteLine("impossivel calcular"); }
            else
            {
                media = soma / n;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}