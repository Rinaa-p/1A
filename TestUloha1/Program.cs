using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Napis slovo: ");
        string slovo = Console.ReadLine();

        int index = slovo.Length;
        int inde = index + 1;

        Random cislo = new Random();
        int ind = cislo.Next(1, inde);

        Console.WriteLine($"Napiste pismeno pod tim to indexem: {ind}");
        ind -= 1;
        char uzivind = char.Parse(Console.ReadLine());
        
        if(slovo.IndexOf(uzivind) == ind ){
            Console.WriteLine("Super, mas pravdu!");
        }else{
            Console.WriteLine("Zkus to jeste jednou!");
        }
    }
}