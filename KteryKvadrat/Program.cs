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
            Console.WriteLine("Je to uprostred mezi levemi hornim kvadrantem a pravem hornim kvadrantem");
        }else if (x == 0 && y < 0){
            Console.WriteLine("Je to uprostred mezi levem dolnim kvadrantem a pravim dolnim kvadrantem");
        }else if (x > 0 && y == 0){
            Console.WriteLine("Je to uprostred mezi pravem hornim kvadrantem a pravem dolnim kvadrantem");
        }else if (x < 0 && y == 0){
            Console.WriteLine("Je to uprostred mezi levem hornim kvadrantem a levem hornim kvadrantem");
        }else if (x > 0 && y > 0){
            Console.WriteLine("Je to nekde v pravem hornim kvadrantu");
        }else if (x > 0 && y < 0){
            Console.WriteLine("Je to nekde v pravem dolnim kvadrantu");
        }else if (x < 0 && y > 0){
            Console.WriteLine("Je to nekde v levem hornim kvadrantu");
        }else{
            Console.WriteLine("Je to nekde v levem dolnim kvadrantu");
        }

    
        // Konec vašeho kódu
    }
}