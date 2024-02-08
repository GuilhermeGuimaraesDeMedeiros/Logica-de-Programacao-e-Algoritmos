using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            String[] vet = Console.ReadLine().Split(' ');

            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);  

            while (X != Y)
            {
                if (X > Y) { Console.WriteLine("Decrescente"); }
                if (X < Y) { Console.WriteLine("Crescente"); }

                vet = Console.ReadLine().Split(' ');

                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}