using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double π, R, area;

            π = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = π * R * R;
            
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
