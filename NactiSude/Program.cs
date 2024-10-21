using System;

class MainClass {
    public static void Main (string[] args) {
        Console.WriteLine("Zadej sude cislo: ");
        int i = int.Parse(Console.ReadLine());
        int a = i % 2;
        while (a != 0)
        {
            Console.WriteLine("To Neni sude, zkus to znovu: ");
            i = int.Parse(Console.ReadLine());
            a = i % 2;
        }

        Console.WriteLine($"Neblizsi liche vyssi cislo je: {i+1}");

    }
}