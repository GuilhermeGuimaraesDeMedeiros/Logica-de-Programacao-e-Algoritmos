using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double R, V;

        R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        V = (4.0 / 3) * 3.14159 * Math.Pow(R, 3);

        Console.WriteLine("VOLUME = " + V.ToString("F3", CultureInfo.InvariantCulture));

    }

}
