using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] nome;
            int[] idade;
            double[] altura;

            N= int.Parse(Console.ReadLine());
            nome = new string[N];
            idade = new int[N];
            altura = new double[N];
            
            
            for (int i = 0; i < N; i++) 
            {
                String[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }
            
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + altura[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            int cont = 0;
            for (int i = 0; i < N;i++)
            {
                if (idade[i] < 16)
                {
                    cont = cont + 1;
                } 
            }
            double porcentagem = (double) cont / N * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

        }
    }
}