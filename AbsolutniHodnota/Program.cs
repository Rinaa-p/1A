using System;

class MainClass {
    public static void Main (string[] args) {
        // sem přijde váš kód   
        Console.Write("Napis cislo: ");
        float a = float.Parse(Console.ReadLine());

        if (a >= 0)
        {
            
            Console.WriteLine($"Absolutni hdnota toho cisla je: {a}");
        }
        else
        {
            a = a * -1;
            Console.WriteLine($"Absolutni hdnota toho cisla je: {a}");
        }

    }
}