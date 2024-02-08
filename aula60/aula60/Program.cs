using System;
using System.Runtime.CompilerServices;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];

            for (int i = 0; i < N; i++)
            {
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Nomes lidos:");
            foreach (string x in nomes)
            {
                Console.WriteLine(x);
            }
        }
    }
}