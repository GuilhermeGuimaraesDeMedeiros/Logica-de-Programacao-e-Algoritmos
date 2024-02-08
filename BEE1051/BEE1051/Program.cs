using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double salario, imposto1, imposto2, imposto3;

        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if ( salario >= 0.0 && salario <= 2000.0)
        {
            Console.WriteLine("Isento");
        }
        if ( salario > 2000.0 && salario <= 3000.0)
        {
            imposto1 = 0.08 * (salario - 2000.0);
            Console.WriteLine("R$ " + imposto1.ToString("F2", CultureInfo.InvariantCulture));
        }
        if ( salario > 3000.0 && salario <= 4500.0)
        {
            imposto1 = 0.08 * 1000;
            imposto2 = (0.18 * (salario - 3000.0)) + imposto1;
            Console.WriteLine("R$ " + imposto2.ToString("F2", CultureInfo.InvariantCulture));
        }
        if ( salario > 4500.0)
        {
            imposto3 = (salario - 4500.0) * 0.28 + 270 + 80;
            Console.WriteLine("R$ " + imposto3.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}