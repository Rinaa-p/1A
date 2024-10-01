using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
        Console.Write("Kolik procent ziskal zak? ");
        float procent = float.Parse(Console.ReadLine());

        if (procent <= 100 && procent >= 83)
        {
            Console.WriteLine($"Za {procent}% mu nalezi snamka 1 (vyborne)");
        }else if (procent >= 67) {
            Console.WriteLine($"Za {procent}% mu nalezi snamka 2 (chvalitebne)");
        }else if (procent >= 50){
            Console.WriteLine($"Za {procent}% mu nalezi snamka 3 (dobre)");
        }else if (procent >= 33) {
            Console.WriteLine($"Za {procent}% mu nalezi snamka 4(dostatecne)");
        }else if (procent >= 0) {
            Console.WriteLine($"Za {procent}% mu nalezi snamka 5 (nedostatne)");
        }else{
            Console.WriteLine($"Vysledek {procent}% neumim vyhodnit");
        }



    }
}