using System;

class URI
{

    static void Main(string[] args)
    {

        int x, a, g, d;
        x = int.Parse(Console.ReadLine());

        a = 0;
        g = 0;
        d = 0;
        
        while (x != 4)
        {
            if (x == 1) { a = a + 1; }
            else if (x == 2) { g = g + 1; }
            else if (x == 3) { d = d + 1; }

            x = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + a); Console.WriteLine("Gasolina: " + g); Console.WriteLine("Diesel: " + d);
    }
}