using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int tempo, velocidade, distancia;
        double consumo;

        tempo = int.Parse(Console.ReadLine());
        velocidade = int.Parse(Console.ReadLine());

        distancia = tempo * velocidade;

        consumo = distancia / 12.0;

        Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture));

    }

}