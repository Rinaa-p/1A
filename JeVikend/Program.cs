using System;

class MainClass {
    public static void Main (string[] args) {
        // sem přijde váš kód  
        Console.Write("Napis cislo: ");
        int den  = int.Parse(Console.ReadLine());

        if (den <= 5 && den >= 1)
        {
            Console.WriteLine("Bohuzel neni to vikend");
        }else if (den > 5 && den <= 7)
        {
            Console.WriteLine("Mate stesti, je to vikend");
        }else{
            Console.WriteLine("Takovy den v tydnu neexistuje");
        }

    }
}
