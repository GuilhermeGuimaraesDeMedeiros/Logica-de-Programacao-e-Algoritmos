using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double valorPorHora, X;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            X = horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + X.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
