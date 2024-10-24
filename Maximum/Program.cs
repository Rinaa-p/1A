using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int cislo = 0;
        int max = 0;
        do
        {
            Console.Write("Napiste cislo: ");
             cislo = int.Parse(Console.ReadLine());
             if (cislo > max)
             {
                 max = cislo;
             }

        } while (cislo > 0);

        Console.WriteLine($"Nejvetsi cislo bylo: {max}");

    }
}