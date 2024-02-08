using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);

            int[,] A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(vet[j]);    
                }
            }

            
            for (int i = 0;i < M; i++)
            {
                int soma = 0;
                for (int j = 0;j < N; j++)
                {
                    soma += A[i, j];
                }
                Console.WriteLine(soma);
            }


        }
    }
}