using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod1, qte1, cod2, qte2;
            double preco1, preco2, total;

            string[] vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            qte1 = int.Parse(vet[1]);
            preco1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet[0]);
            qte2 = int.Parse(vet[1]);
            preco2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = (qte1 * preco1 + qte2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}