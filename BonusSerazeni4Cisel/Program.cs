using System;
using System.Runtime.InteropServices.JavaScript;

class MainClass {
    public static void Main (string[] args) {
        // sem přijde váš kód  
        List<int> numbers = new List<int>();
        
        Console.Write("zadej prvni cislo: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("zadej druhe cislo: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("zadej treti cislo: ");
        int c = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("zadej ctvrte cislo: ");
        int d = Convert.ToInt32(Console.ReadLine());
        
        numbers.Add(a);
        numbers.Add(b);
        numbers.Add(c);
        numbers.Add(d);

        numbers.Sort();
            foreach (int num in numbers){Console.WriteLine(num);}
            
        
        
    }
}