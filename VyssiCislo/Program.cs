class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Write number x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write number y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x < y) 
        {
            Console.WriteLine("x is less than y");
        }else if (x == y)
        {
            Console.WriteLine("x is equal to y");
        }
        else
        {
            Console.WriteLine("x is greater than y");
        }
    }
}