using System;
using System.Globalization;

namespace aula66
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
        int N;
        N = int.Parse(Console.ReadLine());
        
        double[] A = new double[N];

        String[] vet = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            
            A[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
        }

            int cont = 0;
            for (int i = 0;i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    cont++;
                    Console.Write(A[i] + " ");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(cont);

        }
    }
}