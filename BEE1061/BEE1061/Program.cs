using System;

class URI
{

    static void Main(string[] args)
    {

        int diaInicio, hInicio, mInicio, sInicio, diaFim, hFim, mFim, sFim, diaIniSeg, diaFimSeg, dias, diasResto, horas, horasResto, min, seg;

        string nome;

        String[] vet = Console.ReadLine().Split(' ');
        nome = vet[0];
        diaInicio = int.Parse(vet[1]);

        vet = Console.ReadLine().Split(':');

        hInicio = int.Parse(vet[0]);
        mInicio = int.Parse(vet[1]);    
        sInicio = int.Parse(vet[2]);

        vet = Console.ReadLine().Split(' ');
        nome = vet[0];
        diaFim = int.Parse(vet[1]);

        vet = Console.ReadLine().Split(':');

        hFim = int.Parse(vet[0]);
        mFim = int.Parse(vet[1]);
        sFim = int.Parse(vet[2]);

        diaIniSeg = ((diaInicio - 1) * 24 * 60 * 60 + hInicio * 60 * 60 + mInicio * 60 + sInicio);

        diaFimSeg = ((diaFim - 1) * 24 * 60 * 60 + hFim * 60 * 60 + mFim * 60 + sFim);

        dias = (diaFimSeg - diaIniSeg) / (24 * 3600);
        diasResto = (diaFimSeg - diaIniSeg) % (24 * 3600);
        horas = diasResto / 3600;
        horasResto = diasResto % 3600;
        min = horasResto / 60;
        seg = horasResto % 60;


        Console.WriteLine(dias + " dia(s)");
        Console.WriteLine(horas + " hora(s)");
        Console.WriteLine(min + " minuto(s)");
        Console.WriteLine(seg + " segundo(s)");

    }

}