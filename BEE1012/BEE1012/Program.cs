using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

        String[] vet = Console.ReadLine().Split(' ');

        A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        triangulo = (double) (A * C) / 2;
        circulo = (double) 3.14159 * C * C;
        trapezio = (double)((A + B) * C) / 2;
        quadrado = (double)B * B;
        retangulo = (double)A * B;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

    }

}