using System;

class Program
{
    static void Main(string[] args)
    {
        string[] numerosStr = Console.ReadLine().Split(' ');

        int[] numeros = new int[numerosStr.Length];

        for (int i = 0; i < numerosStr.Length; i++)
        {
            numeros[i] = int.Parse(numerosStr[i]);
        }

        Array.Sort(numeros);

        Console.WriteLine("Valores em ordem crescente:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine();

        Console.WriteLine("Valores na sequência em que foram lidos:");
        Console.WriteLine(string.Join(" ", numerosStr));
    }
}
