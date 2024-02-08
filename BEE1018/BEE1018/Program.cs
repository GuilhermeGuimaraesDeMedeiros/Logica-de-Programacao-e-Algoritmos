using System;
using System.Collections;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int N, cem, restoCem, cinquenta, restoCinquenta, vinte, restoVinte, dez, restoDez, cinco, restoCinco, dois, restoDois, um;

        N = int.Parse(Console.ReadLine());

        cem = N / 100;
        restoCem = N % 100;
        cinquenta = restoCem / 50;
        restoCinquenta = restoCem % 50;
        vinte = restoCinquenta / 20;
        restoVinte = restoCinquenta % 20;
        dez = restoVinte / 10;
        restoDez = restoVinte % 10;
        cinco = restoDez / 5;
        restoCinco = restoDez % 5;
        dois = restoCinco / 2;
        restoDois = restoCinco % 2; 
        um = restoDois / 1;

        Console.WriteLine(N);
        Console.WriteLine(cem + " nota(s) de R$ 100,00");
        Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
        Console.WriteLine(vinte + " nota(s) de R$ 20,00");
        Console.WriteLine(dez + " nota(s) de R$ 10,00");
        Console.WriteLine(cinco + " nota(s) de R$ 5,00");
        Console.WriteLine(dois + " nota(s) de R$ 2,00");
        Console.WriteLine(um + " nota(s) de R$ 1,00");

    }

}