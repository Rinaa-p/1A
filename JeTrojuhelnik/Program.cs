using System;

class MainClass {
    public static void Main (string[] args) {
      
        string nacteno;
      
        Console.Write("Zadej stranu A: ");
        nacteno = Console.ReadLine();
        double stranaA = double.Parse(nacteno);
      
        Console.Write("Zadej stranu B: ");
        nacteno = Console.ReadLine();
        double stranaB = double.Parse(nacteno);
      
        Console.Write("Zadej stranu C: ");
        nacteno = Console.ReadLine();
        double stranaC = double.Parse(nacteno);
      
        // Sem přijde váš kód
        bool lzeSestavit = true;
        bool lzeSestavit2 = false;

        if (stranaA + stranaB > stranaC)
        {
            if (stranaA + stranaC > stranaB)
            {
                if (stranaB + stranaC > stranaA)
                {
                    Console.WriteLine(lzeSestavit);
                }
            }
        }else
        {
            Console.WriteLine(lzeSestavit2);
        }
        
    }
}