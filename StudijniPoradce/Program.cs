using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
        Console.WriteLine("Kolik procent ziskal zak z matematiky?");
        int math = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Kolik procent ziskal zak z ceskeho jazyka?");
        int cj = Convert.ToInt32(Console.ReadLine());

        if (math > 66 && cj > 66)
        {if(math>cj){
                Console.WriteLine("Doporucujeme studovat technicky obor");
            }else{
                Console.WriteLine("Doporucujeme studovat humanitni obor");
            }
        }else if (math <= 66){
            Console.WriteLine("Doporucujeme studovat humanitni obor");
        }else if (cj <=66){
            Console.WriteLine("Doporucujeme studovat technicky obor");
        }else{
            Console.WriteLine("Doporucujeme studovat remeslny obor");
        }


    }
}