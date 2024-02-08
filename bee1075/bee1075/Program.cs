using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int N;

        N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            double x, y, z, media;
            String[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            media = ((2 * x) + (3 * y) + (5 * z)) / 10;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }

    }
}