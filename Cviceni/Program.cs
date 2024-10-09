class MainClass
{
    public static void Main(string[] args)
    {
        int skore = 0;
        Console.WriteLine("Kolik je 2 + 4?");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a == 6)
        {
            skore = skore + 5;
        }
        else
        {
            skore = skore - 3;
        }

        Console.WriteLine("Ktere pismo je prvni v abecede? ");
        char b = Console.ReadKey().KeyChar;

        if (b == 'a' || b == 'A')
        {
            skore = skore + 5;
        }
        else
        {
            skore = skore - 3;
        }

        Console.WriteLine("Je cislo 13 sude (A/N)? ");
        char c = Console.ReadKey().KeyChar;
        if (c == 'A')
        {
            skore = skore + 5;
        }
        else
        {
            skore = skore - 3;
        }

        Console.WriteLine($"Your skore: {skore}");
    }
}