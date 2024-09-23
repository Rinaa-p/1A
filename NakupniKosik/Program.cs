using System;

class MainClass {
    public static void Main (string[] args) {

        // string zbozi1 = "Vejce";
        // float cena1 = 3.5f;
        //
        // string zbozi2 = "Rohlík";
        // float cena2 = 1.9f;
        //
        // string zbozi3 = "Chleba";
        // float cena3 = 25f;  
      
        // Sem přijde váš kód
        Console.WriteLine ("Co chteli bych koupit?");
        string zbozi1 = Console.ReadLine ();
        Console.WriteLine ("Kolik to stoji?");
        float cena1 = float.Parse (Console.ReadLine ());
        
        Console.Write($"{zbozi1} (");
        Console.Write(cena1.ToString("F2"));
        Console.WriteLine("): Kolik kusu chcete?");
        int kus1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Neco jeste?");
        string zbozi2 = Console.ReadLine ();
        Console.WriteLine("Kolik to stoji?");
        float cena2 = float.Parse (Console.ReadLine ());
        
        Console.Write($"{zbozi2} (");
        Console.Write(cena2.ToString("F2"));
        Console.WriteLine("): Kolik kusu chcete?");
        int kus2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Co jeste?");
        string zbozi3 = Console.ReadLine ();
        Console.WriteLine("Kolik to stoji?");
        float cena3 = float.Parse (Console.ReadLine ());
        
        Console.Write($"{zbozi3} (");
        Console.Write(cena3.ToString("F2"));
        Console.WriteLine("): Kolik kusu chcete?");
        int kus3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Maximalni pocet kusu v nasem obchode, uz nemuzete nic brat");
        
         float result = kus1 * cena1 + kus2 * cena2 + kus3 * cena3;
        
         Console.Write("Cely nakup bude stat: ");
         Console.WriteLine(result.ToString("F2"));
        
        // Konec prostoru pro kód
    }
}