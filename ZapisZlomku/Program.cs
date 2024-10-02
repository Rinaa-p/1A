using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
        Console.WriteLine("Zadej citatele:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadej jmenovatele:");
        int y = int.Parse(Console.ReadLine());
        
        if (y == 0){
            Console.WriteLine($"{x}/{y} neni platny zlomek");
        }
        else if (x % y == 0){
            Console.WriteLine($"{x}/{y} = {x/y}");
        }else if (x % y != 0)
        {if(x<y){
                Console.WriteLine($"{x}/{y} neumim zjednodusit");
            }else if (x>y)
            {
                Console.WriteLine($"{x}/{y} = {x / y} a {x % y}/{y}");
            }

        }
    
    }
}