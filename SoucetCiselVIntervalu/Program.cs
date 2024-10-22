using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Zadej jeden kraj intervalu: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Zadej druhy kraj intervalu: ");
        int a = int.Parse(Console.ReadLine());
        int x = i;
        int y = 0;
        while (x != a + 1)
        {
            y += x;
            x++;
        }

        Console.WriteLine(y);

    }
}