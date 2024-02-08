using System;
using System.Runtime.Serialization;

class URI
{

    static void Main(string[] args)
    {

        int soma, M, N;

        String[] vet = Console.ReadLine().Split(' ');
        M = int.Parse(vet[0]);
        N = int.Parse(vet[1]);

        while (M != 0 && N != 0)
        {
            int start = Math.Min(M, N);
            int end = Math.Max(M, N);
            soma = 0;
            for (int i = start; i <= end; i++)
            {
                soma = soma + i;
                Console.Write(i + " ");
            }

            Console.WriteLine("sum=" + soma);

            vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);
        }
    }
}