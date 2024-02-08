using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace ExercicioAula25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double idadeMedia;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            idadeMedia = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " +  nome1 + " e " + nome2 + " é de " + idadeMedia.ToString("F1", CultureInfo.InvariantCulture) + " anos");

        }
    }
}