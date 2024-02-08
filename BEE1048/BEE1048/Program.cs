using System;
using System.Globalization;


class URI
{

    static void Main(string[] args)
    {

        double Salario, NovoSalario;

        Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (Salario <= 400.0) { NovoSalario = Salario * 1.15; }
        else if (Salario > 400.0 && Salario <= 800.0) { NovoSalario = Salario * 1.12; }
        else if (Salario > 800.0 && Salario <= 1200.0) { NovoSalario = Salario * 1.10; }
        else if (Salario > 1200.0 && Salario <= 2000.0) { NovoSalario = Salario * 1.07; }
        else { NovoSalario = Salario * 1.04; }

        Console.WriteLine("Novo salario: " + NovoSalario.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + (NovoSalario - Salario).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: " + (int) ((((NovoSalario - Salario) / Salario) * 100)+0.5)+ " %");

    }

}