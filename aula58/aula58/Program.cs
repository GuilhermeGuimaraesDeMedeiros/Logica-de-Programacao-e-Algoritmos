using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double soma, media;
            double[] A;

            N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = new double[N];
            soma = 0;

            String[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                soma = soma + A[i];

                Console.Write(A[i].ToString("F1", CultureInfo.InvariantCulture) +" ");
            }
            Console.WriteLine();
            media = soma / N;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}