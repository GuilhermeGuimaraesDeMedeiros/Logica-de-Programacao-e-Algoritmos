using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            String[] nome = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];

            for (int i = 0; i < N; i++)
            {
                String[] s = Console.ReadLine().Split(' ');
                nome[i] = (s[0]);
                nota1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);


            }
            double[] media = new double[N];

            for (int i = 0;i < N; i++)
            {
                media[i] = ((nota1[i] + nota2[i]) / 2.0);
                
            }
            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0; i < N; i++)
            {
                if (media[i] >= 6.0) 
                {
                    
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}