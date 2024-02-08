using System;
using System.Linq;
using System.Globalization;
using System.Net.Http.Headers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            double[] altura = new double[N];
            char[] sexo = new char[N];

            for (int i = 0; i < N; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(aux[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(aux[1]);
            }

            double soma = 0.0;
            int countF = 0;
            int countM = 0;

            for (int i = 0;i < N; i++)
            {
                if (sexo[i] == 'F')
                {
                    soma = soma + altura[i];
                    countF++;
                }
                else
                {
                    countM++;
                }
            }
            double media = (double) soma / countF;
            double menor = altura.Min();
            double maior = altura.Max();

            Console.WriteLine("Menor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + countM);

        }
    }
}