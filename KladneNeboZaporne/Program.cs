using System;

class MainClass {
    public static void Main (string[] args) {
        // sem přijde váš kód 
        Console.Write("Napiste cislo: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("Je to nula");
        }else if (n % 2 == 1 )
        {
            Console.WriteLine("Je to zaporne cislo");
        }else {
            Console.WriteLine("Je to kladne cislo");
        }

    }
}