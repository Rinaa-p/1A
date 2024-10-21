using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadej cisla, ja jej budu scitat. Napis 0 kdyz ukoncis.");
        int i = int.Parse(Console.ReadLine());
        int a = i;
        

        while (i != 0)
        {
            Console.Write("Napis dalsi cislo: ");
            i = int.Parse(Console.ReadLine());
            a += i;
        }

        Console.WriteLine($"Soucet zadanych cisel: {a}");
    }
}