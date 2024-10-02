using System;

class MainClass {
    public static void Main (string[] args) {

        Console.Write("Stiskni klávesu: ");      
        char znak = Console.ReadKey().KeyChar;
        Console.WriteLine();
      
        // Sem přijde váš kód
        // int ascii = (int)znak;
        switch (znak)
        {
            case char a when (a >= 'A' && a <= 'Z' || a>= 'a' && a<= 'z'):
                Console.WriteLine("je to bukva");
                break;
            case char digit when Char.IsDigit(digit):
                Console.WriteLine("je to cislo");
                break;
            default: Console.WriteLine("je to jiny symbol");
                break;
        }
        


        // Konec vašeho kódu

    }
}