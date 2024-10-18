using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Kolik si ziskal bodu s matematiky?");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Kolik si ziskal bodu z fyziky?");
        int f = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Kolik si ziskal bodu z chenie?");
        int ch = int.Parse(Console.ReadLine());
        if (m + f >= 140 || m + ch >= 140)
        {
            Console.WriteLine($"M: {m}, F: {f}, Ch: {ch} => PRIJAT");
        }else if (m + f + ch >= 180)
        {
            if (m >= 65 && f >= 55 && ch >= 50)
            {
                Console.WriteLine($"M: {m}, F: {f}, Ch: {ch} => PRIJAT");
            }else {
                Console.WriteLine($"M: {m}, F: {f}, Ch: {ch} => NEPRIJAT");
            }
        }else {
            Console.WriteLine($"M: {m}, F: {f}, Ch: {ch} => NEPRIJAT");
        }

        
    }
}