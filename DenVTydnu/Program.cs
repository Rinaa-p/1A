using System;

class MainClass {
    public static void Main (string[] args) {
        // sem přijde váš kód  
        Console.Write("Napiste cislo: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n==1){
            Console.WriteLine("Je to pondeli"); }
        else if (n == 2)
        {
            Console.WriteLine("Je to uteri");
        }else if (n == 3)
        {
            Console.WriteLine("Je to streda");
        }else if (n == 4){
            Console.WriteLine("Je to ctvrtek");
        }else if (n == 5)
        {
            Console.WriteLine("Je to patek");
        }else if (n == 6)
        {
            Console.WriteLine("Je to sobota");
        }else if (n == 7){
            Console.WriteLine("Je to nedele");
        }else{
            Console.WriteLine("Takovy den v tydnu neexistuje");
        }

    }
}