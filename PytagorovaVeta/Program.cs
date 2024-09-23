using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
    
         Console.Write("Prvni odvesna: ");
         int x = int.Parse(Console.ReadLine());
         
         Console.Write("Prepona: ");
         int y = int.Parse(Console.ReadLine());

         if (y - x >= 1)
         {
             double xy = y * y - x * x;
             double result = Math.Sqrt(xy);

             Console.WriteLine($"Druha odvesna: {result}");
         }
         else
         {
             Console.WriteLine("Spocitat nelze");
         }
         // Konec prostoru pro kód
    }
}