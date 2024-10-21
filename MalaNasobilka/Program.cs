using System;

class MainClass {
    public static void Main (string[] args) {
        int zaklad = 7;
      
        // zde začíná váš kód
        int i = 0;
        while (i<11)
        {
            Console.WriteLine($"{i} * {zaklad} = {i*zaklad}");
            i++;
        }

    }
}