using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        while (x < 0.0 || x > 10.0)
        {
            Console.WriteLine("nota invalida");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        double y = double.Parse(Console.ReadLine());
        while (y < 0.0 || y > 10.0)
        {
            Console.WriteLine("nota invalida");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        double media = (x + y) / 2.0;
        Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}