using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] A = new double[N];

            String[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }
            double maior = A[0];
            double posicao = A[0];

            for (int i = 1; i < N; i++)
            {
                if (A[i] > maior)
                {
                    maior = A[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}