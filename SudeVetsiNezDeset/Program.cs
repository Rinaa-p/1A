using System;

class MainClass {
    public static void Main (string[] args) {
        Console.Write("Napis cislo sude a vetsi nez 10: ");
        int i = int.Parse(Console.ReadLine());
        while (i % 2 != 0 || i < 10)
        {
            Console.WriteLine("To nevyhovuje podminkam (sude a vetsi ne 10), zkos to znovu: ");
            i = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"zadal jsi {i}");


    }
}