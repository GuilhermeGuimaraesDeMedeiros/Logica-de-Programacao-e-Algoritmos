using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double notaA, notaB, media;

        notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (3.5 * notaA + 7.5 * notaB) / 11;

        Console.WriteLine("MEDIA = " +  media.ToString("F5", CultureInfo.InvariantCulture));

    }

}