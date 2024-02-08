using System;
using System.Globalization;


class URI
{

    static void Main(string[] args)
    {

        int X, total;

        X = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        total = X * 2;

        Console.WriteLine(total + " minutos");
        
    }

}