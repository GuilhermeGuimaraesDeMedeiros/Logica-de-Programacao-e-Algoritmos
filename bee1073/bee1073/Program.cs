using System;
class URI
{

    static void Main(string[] args)
    {

        double x, N;
        N = int.Parse(Console.ReadLine());

        if (N > 5 && N < 2000)
        {
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    x = Math.Pow(i, 2);
                    Console.WriteLine(i + "^" + 2 + " = " + x);
                }
            }
        }
    }
}