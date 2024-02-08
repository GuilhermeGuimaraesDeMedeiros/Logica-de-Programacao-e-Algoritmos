using System;
using System.Linq;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] A = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                String[] aux = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(aux[j]);
                    
                }
                
            }
            
            for (int i = 0;i < N; i++)
            {
                int maior = A[i, 0];
                for (int j = 0;j < N; j++)
                {
                    if (A[i, j] > maior)
                    {
                        maior = A[i, j];
                    }
                }
                Console.WriteLine(maior);
            }

        }
    }
}