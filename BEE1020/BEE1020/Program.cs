using System;

class URI
{

    static void Main(string[] args)
    {

        int idadeDias, anos, restoAnos, meses, restoMeses, dias;

        idadeDias = int.Parse(Console.ReadLine());

        anos = idadeDias / 365;
        restoAnos = idadeDias % 365;
        meses = restoAnos / 30;
        dias = restoAnos % 30;

        Console.WriteLine(anos + " ano(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");

    }

}