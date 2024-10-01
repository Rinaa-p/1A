using System;

class MainClass {
    public static void Main (string[] args) {
        // sem přijde váš kód    
        Console.Write("Napiste vas rok narozeni: ");
        int rok = int.Parse(Console.ReadLine());

        if (rok <= 1940 && rok >= 1936)
        {
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 60}");
        }else if (rok >= 1941 && rok <= 1946)
        {
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 61}");
        }else if (rok >= 1947 && rok <= 1952) {
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 62}");
        }else if (rok >= 1953 && rok <= 1958){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 63}");
        }else if (rok >= 1959 && rok <= 1964){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 64}");
        }else if (rok >= 1965 && rok <= 1970){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 65}");
        }else if (rok >= 1971 && rok <= 1976){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 66}");
        }else if (rok >= 1977 && rok <= 1982){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 67}");
        }else if (rok >= 1983 && rok <= 1988){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 68}");
        }else if (rok >= 1989 && rok <= 1994){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 69}");
        }else if (rok >= 1995 && rok <= 2000){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 70}");
        }else if (rok >= 2001 && rok <= 2005){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 71}");
        }else if (rok >= 2006 && rok <= 2022){
            Console.WriteLine($"Pujdes do duchodu v roce {rok + 72}");
        }else{
            Console.WriteLine("Nemuzu to spocitat");
        }
    }
}