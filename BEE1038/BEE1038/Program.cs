using System;
using System.Globalization;


class URI
{

    static void Main(string[] args)
    {

        int codigo, quantidade;
        double preço;

        String[] vet = Console.ReadLine().Split(' ');
        
        codigo = int.Parse(vet[0]);
        quantidade = int.Parse(vet[1]);

        if (codigo == 1)
        {
            preço = quantidade * 4.0; Console.WriteLine("Total: R$ " + preço.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (codigo == 2) { preço = quantidade * 4.50; Console.WriteLine("Total: R$ " + preço.ToString("F2", CultureInfo.InvariantCulture)); }
        else if (codigo == 3) { preço = quantidade * 5.0; Console.WriteLine("Total: R$ " + preço.ToString("F2", CultureInfo.InvariantCulture)); }
        else if (codigo == 4) { preço = quantidade * 2.0; Console.WriteLine("Total: R$ " + preço.ToString("F2", CultureInfo.InvariantCulture)); }
        else if (codigo == 5) { preço = quantidade * 1.5; Console.WriteLine("Total: R$ " + preço.ToString("F2", CultureInfo.InvariantCulture)); }
        
    }

}