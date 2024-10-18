using System;
using System.Security.AccessControl;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Kolkik sten ma kostka? ");
        int sten = int.Parse(Console.ReadLine());
        sten += 1;

        Random stenR = new Random();
        int st = stenR.Next(1, sten);
        int st1 = stenR.Next(1, sten);
        int st2 = stenR.Next(1, sten);

        Console.WriteLine($"1. hod: {st}");
        Console.WriteLine($"2. hod: {st1}");
        Console.WriteLine($"3. hod: {st2}");
        Console.WriteLine($"Prumerna hodnota: {(st + st1 + st2)/3}");
        
    }
}