using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double a, b, c;

        string[] input = Console.ReadLine().Split(' ');

        a = double.Parse(input[0], CultureInfo.InvariantCulture);
        b = double.Parse(input[1], CultureInfo.InvariantCulture);
        c = double.Parse(input[2], CultureInfo.InvariantCulture);


        double[] sides = { a, b, c };
        Array.Sort(sides);
        Array.Reverse(sides);

        a = sides[0];
        b = sides[1];
        c = sides[2];


        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }

        if (a == b && b == c)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}
