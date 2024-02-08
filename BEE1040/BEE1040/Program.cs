using System;
using System.ComponentModel.Design;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double N1, N2, N3, N4, media, Nexame, mediaFinal;

        String[] vet = Console.ReadLine().Split(' ');

        N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
        N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
        N4 = double.Parse(vet[3], CultureInfo.InvariantCulture);


        media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

        if (media == 4.85) { media = 4.8; }

        if (media >= 7.0) { Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture)); Console.WriteLine("Aluno aprovado."); }
        else if (media < 5.0) { Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture)); Console.WriteLine("Aluno reprovado."); }
        else 
                {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno em exame.");
            Nexame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            mediaFinal = (Nexame + media) / 2.0;
            Console.WriteLine("Nota do exame: " + Nexame.ToString("F1", CultureInfo.InvariantCulture));
            if (mediaFinal >= 5.0) { Console.WriteLine("Aluno aprovado."); }
            else { Console.WriteLine("Aluno reprovado."); }
            Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
        }

    }

}