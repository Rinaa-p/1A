using System;

class MainClass {
    public static void Main (string[] args) {
          
        Console.Write("Napis cas v sekundach: ");
        int sek = int.Parse(Console.ReadLine());

        int min = sek / 60 ;
        int hour = min / 60;
        int mino = min % 60;
        int seko = sek % 60 ; 
          
        Console.WriteLine($"{sek} sekonds = {hour} hours, {mino} minutes, {seko} seconds.");
    }
}