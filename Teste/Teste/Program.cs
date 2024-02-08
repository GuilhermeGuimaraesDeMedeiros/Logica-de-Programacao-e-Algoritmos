using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        double N1, N2, T;

        N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        T = N1 + N2;
        
        Console.WriteLine("NOTA FINAL = " + T.ToString("F1"), CultureInfo.InvariantCulture);

        if (T < 60.0)
        {
            Console.WriteLine("REPROVADO");
        }
    }
}
