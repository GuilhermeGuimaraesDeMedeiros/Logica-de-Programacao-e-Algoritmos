using System;

class URI
{

    static void Main(string[] args)
    {

        int N;
        N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int x, y, min, max;
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            
            int start = Math.Min(x, y);
            int end = Math.Max(x, y);

            int soma = 0;

            for (int j = start + 1; j < end; j++)
            {
                if (j %2 != 0)
                {
                    soma = soma + j;
                }
                 
            }
            Console.WriteLine(soma);
        }
    }
}

