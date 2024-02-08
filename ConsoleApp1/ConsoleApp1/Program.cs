using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int idade, n;
        double soma, media;
        soma = 0;
        n = 0;
        idade = int.Parse(Console.ReadLine());

        while (idade >=0)
        {
            soma = soma + idade;
            n = n + 1;

            idade = int.Parse(Console.ReadLine());
        }
        media = soma / n;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}