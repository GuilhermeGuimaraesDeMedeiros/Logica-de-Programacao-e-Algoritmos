using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            
            
           
            for (int i = 0; i < N; i++)
            {
                String[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                idades[i] = int.Parse(vet[1]);

            }
            int maior = idades[0];
            int posicao = idades[0];
            string x = nomes[0];
            for (int i = 1;i < N;i++)
            {
                if (idades[i] > maior)
                {
                    maior = idades[i];
                    posicao = i;
                    x = nomes[i];
                   
                }
                
            }
            Console.WriteLine("Pessoa mais velha: " + x);

        }
    }
}