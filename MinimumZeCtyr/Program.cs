using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int pocty = 0;
        int cislo = 0;
        int min = Int32.MaxValue;

        do
        {
            Console.Write("Zadej cislo: ");
            cislo = int.Parse(Console.ReadLine());
            pocty++;
            if (pocty % 4 == 0)
            {
                int cislo4 = cislo;
                if (cislo4<min)
                {
                    min = cislo4;
                    
                }
            }
        } while (cislo > 0 );

        Console.WriteLine($"Minimalne cislo z 4: {min}");
    }
}