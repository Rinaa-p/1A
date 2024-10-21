using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Napis cislo delitelne 5: ");
        int i = int.Parse(Console.ReadLine());

        while (i % 5 != 0)
        {
            Console.Write("To neni delitelne 5, zkus to znovu: ");
            i = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"{i} / 5 = {i/5}");
    }
}