using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int sudy = 0;
        int lichy = 0;
        int cisla = 0;

        do
        {
            Console.WriteLine("Napiste cislo");
            cisla = int.Parse(Console.ReadLine());
            if (cisla % 2 == 0)
            {
                sudy++;
            }
            else
            {
                lichy++;
            }


        } while (cisla > 0);

        Console.WriteLine($"Sude cisla: {sudy}, licha cisla {lichy}");
    }
}