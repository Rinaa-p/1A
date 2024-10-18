using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
        
        Random knp1 = new Random();
        int knp = knp1.Next(0, 3);
        Console.WriteLine("Jakou figuru chcete pouzit? (k/n/p)");
        char uziv = Console.ReadKey().KeyChar;
        
        switch (uziv)
        {case 'k': Console.WriteLine("\nMate vybrany Kamen");
                switch (knp)
                { case 0: Console.Write("Ja mam Kamen, takze remize"); break;
                    case 1: Console.Write("Ja mam Papir, takze jsi prohral"); break;
                    case 2: Console.Write("Ja mam Nuzky, takze jsi vyhral");break;
                }
            break;
            case 'n': Console.WriteLine("\nMate vybrane Nuzky");
                switch (knp)
                { case 0: Console.Write("Ja mam Kamen, takze jsi prohral"); break;
                    case 1: Console.Write("Ja mam Papir, takze jsi Vyhral"); break;
                    case 2: Console.Write("Ja mam Nuzky, takze remize");break;
                }
                break;
            case 'p': Console.WriteLine("\nMate vybrany Papir");
                switch (knp)
                { case 0: Console.Write("Ja mam Kamen, takze jsi vyhral"); break;
                    case 1: Console.Write("Ja mam Papir, takze remize"); break;
                    case 2: Console.Write("Ja mam Nuzky, takze jsi prohral");break;
                }
                break;
            default: Console.WriteLine("\nNemame takovou odpoved");
                break;
        } 
        
       
    }
}