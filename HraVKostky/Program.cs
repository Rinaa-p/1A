using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
        Random cislo = new Random();
        int cis = cislo.Next(1, 7);
        Console.WriteLine($"{cis} je moje cislo, stiskni klavesu at hodi tvoje cislo");
        Console.ReadKey();
        Random num = new Random();
        int number = num.Next(1, 7);
        if (number > cis)
        {
            Console.WriteLine($"\n {number}:{cis} Vyhral jsi");
        }else if (number < cis){
            Console.WriteLine($"\n {number}:{cis} Prohral jsi");
        }else{
            Console.WriteLine($"\n {number}:{cis} Remiza");
        }
    }
}