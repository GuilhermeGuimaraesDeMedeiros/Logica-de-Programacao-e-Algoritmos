﻿using System;

class URI
{

    static void Main(string[] args)
    {

        int X;

        X = int.Parse(Console.ReadLine());

        if (X >= 1 && X <= 1000)
        {
            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }
        }
        
    }

}