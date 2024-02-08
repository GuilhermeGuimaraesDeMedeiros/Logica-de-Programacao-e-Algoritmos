using System;
using System.Globalization;

namespace ExercicioAula24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Base, altura, area, perimetro, diagonal;

            Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = Base * altura;

            perimetro = 2.0 * Base + 2.0 * altura;

            diagonal = Math.Sqrt(Base * Base + altura * altura);

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}