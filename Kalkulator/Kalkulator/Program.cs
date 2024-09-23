using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Napis cislo 1: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Napis cislo 2: ");
        float b = float.Parse(Console.ReadLine());
        
        Console.WriteLine($"Scitani {a+b}, odcitani {a-b}, nasobeni {a*b}, deleni {a/b}");

    }
}

  