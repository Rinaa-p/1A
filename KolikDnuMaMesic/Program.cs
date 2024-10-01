using System;

class MainClass {
    public static void Main (string[] args) {
        // sem přijde váš kód  
        Console.WriteLine("Napiste cislo mesicu: ");
        int mesic = int.Parse(Console.ReadLine());
        
        // if (mesic <= 0 || mesic >= 13)
        // {
        //     Console.WriteLine("Takovy mesic neni");
        // }

        switch (mesic)
        {
            case 1: Console.WriteLine("Je to leden, a ma 31 dni");
                break;
            case 2: Console.WriteLine("Je to unor, a ma 28 dni (nekdy 29)");
                break;
            case 3: Console.WriteLine("Je to brezen, a ma 31 dni");
                break;
            case 4: Console.WriteLine("Je to duben, a ma 30 dni");
                break;
            case 5: Console.WriteLine("Je to kveten, a ma 31 dni");
                break;
            case 6: Console.WriteLine("Je to cerven, a ma 30 dni");
                break;
            case 7: Console.WriteLine("Je to cervenec, a ma 31 dni");
                break;
            case 8: Console.WriteLine("Je to srpen, a ma 31 dni");
                break;
            case 9: Console.WriteLine("Je to zari, a ma 30 dni");
                break;
            case 10: Console.WriteLine("Je to rijen, a ma 31 dni");
                break;
            case 11: Console.WriteLine("Je to listopad, a ma 30 dni");
                break;
            case 12: Console.WriteLine("Je to prosinec, a ma 31 dni");
                break;
            default: Console.WriteLine("Takovy mesic neni");
                break;
        }

        
    }
    
    }
