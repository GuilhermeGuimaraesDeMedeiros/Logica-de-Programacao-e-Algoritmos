using System;

class URI
{

    static void Main(string[] args)
    {

        String[] vet = Console.ReadLine().Split(' ');
        int A = int.Parse(vet[0]);
        int N = int.Parse(vet[1]);
        int soma = 0;
        while (N <= 0)
        {
            N = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= N - 1; i++)
        {
            soma = soma + A + i;
        }

        Console.WriteLine(soma);
    }
}

