using System;

class URI
{
    static void Main(string[] args)
    {
        int x, N;

        N = int.Parse(Console.ReadLine());

        if (N < 10000)
        {
            for (int i = 0; i < N; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x % 2 == 0 && x > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (x % 2 == 0 && x < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (x % 2 != 0 && x > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (x % 2 != 0 && x < 0) 
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (x == 0) { Console.WriteLine("NULL"); }
            }
        }
    }
}