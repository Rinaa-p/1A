using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
    Console.Write("Napiste prvni stranu kvadru v cm: ");
    float a = float.Parse (Console.ReadLine ());
    
    Console.Write("Napiste druhu stranu kvadru v cm: ");
    float b = float.Parse (Console.ReadLine ());
    
    Console.Write("Napiste treti stranu kvadru v cm: ");
    float c = float.Parse (Console.ReadLine ());
    
    
    Console.WriteLine($"Objem kvadru je {a * b * c}, a povrch kvadru je {2 * (a * b + b * c + a * c)}");
    
    
        // Konec prostoru pro kód
    }
}