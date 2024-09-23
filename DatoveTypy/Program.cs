using System;

class MainClass {
    public static void Main (string[] args)
    {
        int pocetRohliku = 4;
            Console.WriteLine("Kup " + pocetRohliku + " rohlíků");
        
            float cenaZaLitr = 56.5f;
            Console.WriteLine("Za litr nafty dnes zaplatíte " + cenaZaLitr + "Kč");

            char prvniPismeno = 'A';
            Console.WriteLine("První písmeno abecedy je \"" + prvniPismeno + "\".");
        
            string textZpravy = "textZpravy";
            Console.WriteLine("Přišla mi zpráva s tímto textem: " + textZpravy);

            int autaZaDen = 10;
            Console.WriteLine("Dnes naší ulicí projelo " + autaZaDen + " aut.");

            char interpunkcniZnamenko = '.';
            Console.WriteLine("K oddělení vět v souvětí používáme symbol \"" + interpunkcniZnamenko + "\"");
        
            float delkaHrany = 10.5f;
            Console.WriteLine("Základna trojúhleníka měří " + delkaHrany + " cm.");

            string prijmeni = "Dvorak";
            Console.WriteLine(prijmeni + " je časté příjmení.");
    }
}