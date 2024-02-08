using System;

class URI
{
    static void Main(string[] args)
    {
        int x;

        while (true)
        {
            x = int.Parse(Console.ReadLine());

            if (x == 0)
                break;

            int soma = 0;

            if (x % 2 == 0)
            {
                for (int i = 0; i < 5; i++)
                    soma += x + (2 * i);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    soma += x + (2 * i + 1);
            }

            Console.WriteLine(soma);
        }
    }
}
