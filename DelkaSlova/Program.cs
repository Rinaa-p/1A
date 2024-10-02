using System;

class Program {
    public static void Main (string[] args) {
        int counter = 0;
        int counter2 = 0;
        Console.WriteLine("Napiste slovo: ");
        string a = Console.ReadLine();
        foreach (char x in a)
        {
            if (Char.IsLetter(x))
            {
                counter++;
            }
        }
        Console.WriteLine("napiste jeste jedno slovo");
        string b = Console.ReadLine();
        foreach (char y in b)
        {
            if (Char.IsLetter(y)){counter2++;}
        }

        if (counter > counter2)
        {
            Console.WriteLine($"Prvni slovo \"{a}\" je delsi");
        }else if(counter < counter2){
            Console.WriteLine($"Druhe slovo \"{b}\" je delsi");
        }else{
            Console.WriteLine("Dva slova maji stejnou delku");
        }
    }
}