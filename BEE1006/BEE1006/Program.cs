using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double A, B, C, media;
        
        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (2.0 * A + 3.0 * B + 5.0 * C) / 10.0;

        Console.WriteLine("MEDIA = " +  media.ToString("F1", CultureInfo.InvariantCulture));

    }

}
