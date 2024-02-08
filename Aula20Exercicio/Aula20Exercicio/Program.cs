using System.Globalization;

double largura, comprimento, precoMetroQuadrado, area, preco;

Console.WriteLine("Terreno");
Console.WriteLine("Largura (m): ");
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("comprimento (m): ");
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("preço (metro quadrado): ");
precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


area = largura * comprimento;
preco = area * precoMetroQuadrado;



Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture) + " metros quadrados");
Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais");





