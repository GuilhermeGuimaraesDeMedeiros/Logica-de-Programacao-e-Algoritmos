using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        Double valor, N100, resto100, N50, resto50, N20, resto20, N10, resto10, N5, resto5, N2, resto2, M1, restoM1, M050, restoM050, M025, restoM025, M010, restoM010, M005, restoM005,
            M001;

        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        valor = (int)(valor * 100 + 0.5);

        N100 = (int) valor / 10000;
        resto100 = (int) valor % 10000;
        N50 = (int) resto100 / 5000;
        resto50 = (int) resto100 % 5000;    
        N20 = (int) resto50 /2000;
        resto20 = (int) resto50 % 2000;
        N10 = (int) resto20 / 1000;
        resto10 = (int) resto20 % 1000;
        N5 = (int) resto10 / 500;
        resto5 = (int) resto10 % 500;
        N2 = (int) resto5 / 200;
        resto2 = (int) resto5 % 200;
        M1 = (int) resto2 / 100;
        restoM1 = (int) resto2 % 100;
        M050 = (int)restoM1 / 50;
        restoM050 = (int) restoM1 % 50;
        M025 = (int) restoM050 / 25;
        restoM025 = (int) restoM050 % 25;
        M010 = (int) restoM025 / 10;
        restoM010 = (int) restoM025 % 10;
        M005 = (int) restoM010 / 5;
        restoM005 = (int) restoM010 % 5;
        M001 = (int) restoM005;

        Console.WriteLine("NOTAS:");
        Console.WriteLine(N100 + " nota(s) de R$ 100.00");
        Console.WriteLine(N50 + " nota(s) de R$ 50.00");
        Console.WriteLine(N20 + " nota(s) de R$ 20.00");
        Console.WriteLine(N10 + " nota(s) de R$ 10.00");
        Console.WriteLine(N5 + " nota(s) de R$ 5.00");
        Console.WriteLine(N2 + " nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine(M1 + " moeda(s) de R$ 1.00");
        Console.WriteLine(M050 + " moeda(s) de R$ 0.50");
        Console.WriteLine(M025 + " moeda(s) de R$ 0.25");
        Console.WriteLine(M010 + " moeda(s) de R$ 0.10");
        Console.WriteLine(M005 + " moeda(s) de R$ 0.05");
        Console.WriteLine(M001 + " moeda(s) de R$ 0.01");

    }

}