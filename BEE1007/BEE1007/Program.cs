﻿using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            X = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + X);

        }
    }
}
