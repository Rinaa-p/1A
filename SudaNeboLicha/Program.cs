using System;

class MainClass {
    public static void Main (string[] args) {
        // sem přijde váš kód
        Console.Write("Napis cislo: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Cislo je sude");
        }
        else
        {
            Console.WriteLine("Cislo je liche");
        }

    }
}