using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        String nome1;
        double salario, totalVendas, comissao, salarioTotal;

        nome1 = Console.ReadLine();
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        comissao = totalVendas * 0.15;

        salarioTotal = salario + comissao;

        Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));

    }

}