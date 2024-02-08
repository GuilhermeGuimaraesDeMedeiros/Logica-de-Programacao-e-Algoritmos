using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];

            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(vet[i]);
                
            }
            string[] vet2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                
                B[i] = int.Parse(vet2[i]);
            }

            int[] C = new int[N];

            for (int i = 0; i < N;i++)
            {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }
            Console.WriteLine();

        }
    }
}