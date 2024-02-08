using System;


class URI
{

    static void Main(string[] args)
    {
        int x, golI, golG, vitInter, vitGremio, empate;
        vitInter = 0;
        vitGremio = 0;
        empate = 0;
        x = 1;

        while (x == 1)
        {
            String[] vet = Console.ReadLine().Split(' ');
            golI = int.Parse(vet[0]);
            golG = int.Parse(vet[1]);


            if (golI > golG)
            {
                vitInter++;
            }
            else if (golI < golG)
            {
                vitGremio++;
            }
            else
            {
                empate++;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");

            x = int.Parse(Console.ReadLine());


        }
        int total = vitInter + vitGremio + empate;

        Console.WriteLine(total + " grenais");
        Console.WriteLine("Inter:" + vitInter);
        Console.WriteLine("Gremio:" + vitGremio);
        Console.WriteLine("Empates:" + empate);

        if (vitInter > vitGremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if (vitInter < vitGremio)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }
    }
}
