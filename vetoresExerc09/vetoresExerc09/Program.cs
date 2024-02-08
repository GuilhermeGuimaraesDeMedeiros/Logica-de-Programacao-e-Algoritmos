using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] produtos = new string[N];
            double[] precoCompra = new double[N]; 
            double[] precoVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                produtos[i] = aux[0];
                precoCompra[i] = double.Parse(aux[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);   

            }
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for (int i = 0;i < N;i++)
            {
                if (precoVenda[i] / precoCompra[i] < 1.1)
                {
                    count1 ++;
                }
                else if (precoVenda[i] / precoCompra[i] > 1.2)
                {
                    count2 ++;
                }
                else 
                { 
                    count3 ++;
                }

            }
            double somaV = 0.0;
            double somaC = 0.0;

            for (int i = 0; i < N; i++)
            {
                somaV = somaV + precoVenda[i];
                somaC = somaC + precoCompra[i];

            }
            double lucro = somaV - somaC;

            Console.WriteLine("Lucro abaixo de 10%: " + count1);
            Console.WriteLine("Lucro entre 10% e 20%: " + count3);
            Console.WriteLine("Lucro acima de 20%: " + count2);
            Console.WriteLine("Valor total de compra: " + somaC.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + somaV.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucro.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();




        }
    }
}