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
                String[] aux = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(aux[j]);
                }
                
            }
            for (int i = 0;i < M; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}