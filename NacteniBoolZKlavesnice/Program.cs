using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
        Console.WriteLine("Je hezky den? y/n ");
        char ch = Console.ReadKey ().KeyChar;

        Console.WriteLine("Chces ven? y/n ");
        char ven = Console.ReadKey ().KeyChar;
        // uvnitř tohoto kódu musí vzniknout proměnné jeHezky a chciVen 
        bool chciVen = ch == 'y';
        bool jeHezky = ven == 'y';
    
        // Konec vašeho kódu
    
        if (jeHezky || chciVen)
        {
            Console.WriteLine("Je čas jít ven.");
        }
        else
        {
            Console.WriteLine("Zůstaň radši doma.");
        }
    
    }
}