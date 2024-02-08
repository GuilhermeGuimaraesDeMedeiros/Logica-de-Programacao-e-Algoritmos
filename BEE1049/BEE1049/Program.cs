using System;

class URI
{

    static void Main(string[] args)
    {

        String nome1, nome2, nome3;

        nome1 = Console.ReadLine();
        nome2 = Console.ReadLine();
        nome3 = Console.ReadLine();

        if (nome1 == "vertebrado")
        {
            if (nome2 == "ave")
            {
                if (nome3 == "carnivoro") { Console.WriteLine("aguia"); }
                else if (nome3 == "onivoro") { Console.WriteLine("pomba"); }
            }
            else if (nome2 == "mamifero")
            {
                if (nome3 == "onivoro") { Console.WriteLine("homem"); }
                else if (nome3 == "herbivoro") { Console.WriteLine("vaca"); }
            }
        }
        else if (nome1 == "invertebrado")
        {
            if (nome2 == "inseto")
            {
                if (nome3 == "hematofago") { Console.WriteLine("pulga"); }
                else if (nome3 == "herbivoro") { Console.WriteLine("lagarta"); }
            }
            else if (nome2 == "anelideo")
            {
                if (nome3 == "hematofago") { Console.WriteLine("sanguessuga"); }
                else if (nome3 == "onivoro") { Console.WriteLine("minhoca"); }
            }
        }
    }
}


