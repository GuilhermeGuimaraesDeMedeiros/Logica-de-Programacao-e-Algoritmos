using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];

            String[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(vet[i]);
            }
            double soma = 0.0;
            int count = 0;
            for (int i = 0;i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    soma += A[i];
                    count++;
                }
            }
            double media = (double) soma / count;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));    
        }
    }
}