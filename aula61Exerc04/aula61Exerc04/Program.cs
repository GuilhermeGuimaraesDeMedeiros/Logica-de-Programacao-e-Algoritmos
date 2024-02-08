using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] A = new double[N];

            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }
            double soma = 0.0;
            for (int i = 0;i < N;i++)
            {
                soma += A[i];
            }
            double media = soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));
            for (int i = 0; i < N;i++)
            {
                if (A[i] < media)
                {
                    Console.WriteLine(A[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}