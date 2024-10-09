using System;

class MainClass {
    public static void Main (string[] args) {
        // Sem přijde váš kód
        Console.Write("Zadej x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Zadej y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Je to uprostred mezi vsemi kvardantama");
        }else if (x == 0 && y > 0){
            Console.WriteLine("Je to uprostred mezi prvnim kvadrantem a druhem kvadrantem");
        }else if (x == 0 && y < 0){
            Console.WriteLine("Je to uprostred mezi trtim kvadrantem a ctvrtem kvadrantem");
        }else if (x > 0 && y == 0){
            Console.WriteLine("Je to uprostred mezi prvnim kvadrantem a pctvrtem kvadrantem");
        }else if (x < 0 && y == 0){
            Console.WriteLine("Je to uprostred mezi druhem kvadrantem a treim kvadrantem");
        }else if (x > 0 && y > 0){
            Console.WriteLine("Je to nekde v prvnim kvadrantu");
        }else if (x > 0 && y < 0){
            Console.WriteLine("Je to nekde v ctvrtem kvadrantu");
        }else if (x < 0 && y > 0){
            Console.WriteLine("Je to nekde v druhem kvadrantu");
        }else{
            Console.WriteLine("Je to nekde v tretim kvadrantu");
        }


        // Konec vašeho kódu
    }
}