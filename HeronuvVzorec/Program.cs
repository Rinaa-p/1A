using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
        
        Console.Write("1 strana trojuhelniku: ");
        float a = float.Parse(Console.ReadLine ());
        
        Console.Write("2 strana trojuhelniku: ");
        float b = float.Parse(Console.ReadLine ());
        
        Console.Write("3 strana trojuhelniku: ");
        float c = float.Parse(Console.ReadLine ());
        
        float s = (a + b + c) / 2f;
        
        float s2 = s * (s-a) * (s-b) * (s-c);
        double result = Math.Sqrt(s2);
        Console.Write("Obsah trojuhelnika: ");
        Console.WriteLine(result);
        
        // Konec prostoru pro kód
    }
}