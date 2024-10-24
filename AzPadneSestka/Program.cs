using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chete zahrat? a/n");
        string odp = Console.ReadLine();

        Random t = new Random();

        while (odp == "a") 
        {   
            int x = t.Next(1, 7);
            while (x != 6)
            {
                Console.WriteLine($"vypadlo {x}");
                x = t.Next(1, 7);
            }
            Console.WriteLine("Vypadla 6, chcete pokracovat? n/a");
            odp = Console.ReadLine();
        } 

        

        
        
    }
}