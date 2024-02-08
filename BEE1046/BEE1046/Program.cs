using System;

class URI
{

    static void Main(string[] args)
    {

        int inicio, fim, total;

        String[] vet = Console.ReadLine().Split(' ');

        inicio = int.Parse(vet[0]);
        fim = int.Parse(vet[1]);    

        if (inicio > fim) { total = (24 - inicio) + fim; Console.WriteLine("O JOGO DUROU " + total + " HORA(S)"); }
        else if (inicio == fim) { Console.WriteLine("O JOGO DUROU 24 HORA(S)"); }
        else if (inicio < fim) { total = fim - inicio; Console.WriteLine("O JOGO DUROU " + total + " HORA(S)"); }

    }

}