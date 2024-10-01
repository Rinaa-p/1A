using System;

class MainClass {
    public static void Main (string[] args) {

        Console.Write("Stiskni klávesu: ");      
        char znak = Console.ReadKey().KeyChar;
        Console.WriteLine();
      
        // Sem přijde váš kód
        switch (znak)
        {
            case 'e' :Console.WriteLine("Je samohlaska!");
                break;
            case 'y':Console.WriteLine("Je samohlaska!");
                break;
            case 'u':Console.WriteLine("Je samohlaska!");
                break;
            case 'i':Console.WriteLine("Je samohlaska!");
                break;
            case 'o':Console.WriteLine("Je samohlaska!");
                break;
            case 'a':Console.WriteLine("Je samohlaska!");
                break;
            default:Console.WriteLine("Neni to samohlaska!");
                break;
        }
    

        // Konec vašeho kódu
    
    }
}