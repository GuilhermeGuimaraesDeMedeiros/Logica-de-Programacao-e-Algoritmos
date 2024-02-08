using System;

class URI
{

    static void Main(string[] args)
    {

        int hi, mi, hf, mf, inicioMin, fimMin, total, ht, mt;

        String[] vet = Console.ReadLine().Split(' ');
        hi = int.Parse(vet[0]);
        mi = int.Parse(vet[1]);
        hf = int.Parse(vet[2]);
        mf = int.Parse(vet[3]);

        inicioMin = hi * 60 + mi;
        fimMin = hf * 60 + mf;

        if (inicioMin < fimMin) { total = fimMin - inicioMin; }
        else { total = ((24*60 - inicioMin) + fimMin); }

        ht = total / 60;
        mt = total % 60;

        Console.WriteLine("O JOGO DUROU " + ht + " HORA(S) E " + mt + " MINUTO(S)");
    }

}