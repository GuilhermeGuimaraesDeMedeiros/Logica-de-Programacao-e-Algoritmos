using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N];

            String[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(vet[i]);
                if (A[i] < 0)
                {
                    Console.WriteLine(A[i]);
                }
            }
            
        }
    }
}